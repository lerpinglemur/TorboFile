﻿using Lemur.Operations.FileMatching;
using Lemur.Operations.FileMatching.Actions;
using Lemur.Utils;
using Lemur.Windows;
using Lemur.Windows.MVVM;
using Lemur.Windows.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using TorboFile.Model;

namespace TorboFile.ViewModels.Main {

	/// <summary>
	/// ViewModel for running a CustomSearch.
	/// </summary>
	public class RunSearchVM : ViewModelBase {

		#region COMMANDs



		/// <summary>
		/// Command to run the current search, matching any files that match
		/// the search conditions.
		/// </summary>
		public RelayCommand CmdRunSearch {
			get {
				return this._cmdRunSearch ?? ( this._cmdRunSearch = new RelayCommand(
					async () => await this.RunSearchAsync( this.SearchDirectory )
				) );
			}
		}
		private RelayCommand _cmdRunSearch;

		/// <summary>
		/// Command to run the associated actions on any files found in the search phase.
		/// </summary>
		public RelayCommand CmdRunActions {
			get {
				return this._cmdRunActions ?? ( this._cmdRunActions = new RelayCommand(
					this.RunActionsAsync
				) );
			}
		}
		private RelayCommand _cmdRunActions;

		#endregion

		#region PROPERTIES

		/// <summary>
		/// Models the progression of the current search.
		/// </summary>
		public ProgressVM CurrentProgress {
			get { return this._currentProgress; }
			set {
				this.SetProperty( ref this._currentProgress, value );
			} // set()
		}
		private ProgressVM _currentProgress = new ProgressVM( null );

		/// <summary>
		/// Model of the results from a matching operation.
		/// </summary>
		public FileListVM ResultsList {

			get { return this._resultsList; }

			private set {
				this.SetProperty( ref this._resultsList, value );
			}

		}
		private FileListVM _resultsList;

		public bool HasCheckedItems {
			get {
				return this._resultsList != null && this._resultsList.CheckedItems.Count > 0;
			}
		}

		public CustomSearchData CustomSearch {
			get => _customSearch;
			set {
				this.SetProperty( ref this._customSearch, value );
			}

		}
		private CustomSearchData _customSearch;

		public string SearchDirectory {
			get => _searchDirectory;
			set {

				if( value != this._searchDirectory ) {
					this.SetProperty( ref this._searchDirectory, value );
				}

			} // set()
		}
		private string _searchDirectory;

		#endregion

		/// <summary>
		/// Only run the actions on the selected files.
		/// </summary>
		/// <returns>A Task, apparently.</returns>
		private async void RunActionsAsync() {

			FileActionOperation operation = new FileActionOperation();
			operation.Actions = this.CustomSearch.Actions;
			operation.Targets = this.ResultsList.CheckedItems;

			this.CurrentProgress.Operation = operation;

			try {

				await Task.Run( () => { operation.Run(); } );

			} catch( Exception e ) {

				Console.WriteLine( "ERROR: " + e.ToString() );

			}

			Exception[] exceptions = operation.ErrorList;
			foreach( Exception e in exceptions ) {
				Console.WriteLine( e.ToString() );
			}

			Console.WriteLine( "ACTIONS DONE" );
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		private async Task RunSearchAsync( string path ) {

			//Console.WriteLine( "RUNNING SEARCH" );

			FileMatchOperation matchFinder = this.BuildMatchOperation( this.SearchDirectory );
			matchFinder.OnMatchFound += MatchFinder_OnMatchFound;

			this._currentProgress.Operation = matchFinder;

			//List<FileSystemInfo> matches = matchFinder.Matches;
			//BindingOperations.EnableCollectionSynchronization( matches, resultsLock );

			// Ensure the ResultsModel exists for displaying results.
			this.CreateResultsList();

			try {

				await Task.Run( () => matchFinder.Run() );

			} catch( Exception e ) {
				Console.WriteLine( "ERROR: " + e.ToString() );
			}

			if( this.ResultsList.Items.Count == 0 ) {
				// report no results found.
				Console.WriteLine( "NO RESULTS FOUND" );
			} else {
				//Console.WriteLine( "FOUND RESULTS" );
			}
		} //

		private void MatchFinder_OnMatchFound( FileSystemInfo obj ) {

			//Console.WriteLine( "RESULT FOUND: " + obj.Name );
			if( this.ResultsList != null ) {
				this.ResultsList.Add( obj, true );
			} else {
				Console.WriteLine( "ERROR: RESULT LIST IS NULL" );
			}

		}

		private FileMatchOperation BuildMatchOperation( string basePath ) {

			FileMatchOperation matchOp = new FileMatchOperation( basePath, this._customSearch.Conditions );
			return matchOp;
		}
	
		private FileListVM CreateResultsList() {

			if( this.ResultsList != null ) {
				ResultsList.Clear();
				return this.ResultsList;
			}

			FileListVM checkList = new FileListVM();
			checkList.ShowOpenCmd = true;
			checkList.ShowCheckBox = true;
			checkList.ShowOpenLocationCmd = true;
			checkList.ShowDeleteCmd = true;
	
			/// NOTE: Apparently a public interface member can be protected unless explicitly cast.
			/// This seems insane to me.
			//( (INotifyPropertyChanged)checkList.CheckedItems ).PropertyChanged += CheckedItems_PropertyChanged;

			this.ResultsList = checkList;

			return checkList;

		}

		public bool HasActions() {
			//return this.actionBuilder.HasItems();
			return false;
		}

		/// <summary>
		/// Checks if any conditions have been added to the current match builder.
		/// </summary>
		/// <returns></returns>
		public bool HasConditions() {
			//return this.matchBuilder.HasItems();
			return false;
		}

		/// <summary>
		/// Checks that results exist, and that at least some are selected
		/// for running actions.
		/// </summary>
		/// <returns></returns>
		public bool HasCheckedResults() {
			return this._resultsList != null && this._resultsList.CheckedItems.Count > 0;
		}

		public RunSearchVM( IServiceProvider provider ) : base( provider ) {
		}

	} // class

} // namespace
