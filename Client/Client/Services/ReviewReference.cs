﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2016-06-06 11:57:50
namespace Client.ReviewServices.Library
{
    /// <summary>
    /// There are no comments for ReviewSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ReviewSingle")]
    public partial class ReviewSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Review>
    {
        /// <summary>
        /// Initialize a new ReviewSingle object.
        /// </summary>
        public ReviewSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ReviewSingle object.
        /// </summary>
        public ReviewSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ReviewSingle object.
        /// </summary>
        public ReviewSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Review> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for Review in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ReviewID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ReviewID")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Review")]
    public partial class Review : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Review object.
        /// </summary>
        /// <param name="reviewID">Initial value of ReviewID.</param>
        /// <param name="note">Initial value of Note.</param>
        /// <param name="movieID">Initial value of MovieID.</param>
        /// <param name="userID">Initial value of UserID.</param>
        /// <param name="date">Initial value of Date.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static Review CreateReview(int reviewID, int note, int movieID, int userID, global::System.DateTimeOffset date)
        {
            Review review = new Review();
            review.ReviewID = reviewID;
            review.Note = note;
            review.MovieID = movieID;
            review.UserID = userID;
            review.Date = date;
            return review;
        }
        /// <summary>
        /// There are no comments for Property ReviewID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReviewID")]
        public int ReviewID
        {
            get
            {
                return this._ReviewID;
            }
            set
            {
                this.OnReviewIDChanging(value);
                this._ReviewID = value;
                this.OnReviewIDChanged();
                this.OnPropertyChanged("ReviewID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private int _ReviewID;
        partial void OnReviewIDChanging(int value);
        partial void OnReviewIDChanged();
        /// <summary>
        /// There are no comments for Property Content in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Content")]
        public string Content
        {
            get
            {
                return this._Content;
            }
            set
            {
                this.OnContentChanging(value);
                this._Content = value;
                this.OnContentChanged();
                this.OnPropertyChanged("Content");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _Content;
        partial void OnContentChanging(string value);
        partial void OnContentChanged();
        /// <summary>
        /// There are no comments for Property Note in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Note")]
        public int Note
        {
            get
            {
                return this._Note;
            }
            set
            {
                this.OnNoteChanging(value);
                this._Note = value;
                this.OnNoteChanged();
                this.OnPropertyChanged("Note");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private int _Note;
        partial void OnNoteChanging(int value);
        partial void OnNoteChanged();
        /// <summary>
        /// There are no comments for Property MovieID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("MovieID")]
        public int MovieID
        {
            get
            {
                return this._MovieID;
            }
            set
            {
                this.OnMovieIDChanging(value);
                this._MovieID = value;
                this.OnMovieIDChanged();
                this.OnPropertyChanged("MovieID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private int _MovieID;
        partial void OnMovieIDChanging(int value);
        partial void OnMovieIDChanged();
        /// <summary>
        /// There are no comments for Property UserID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("UserID")]
        public int UserID
        {
            get
            {
                return this._UserID;
            }
            set
            {
                this.OnUserIDChanging(value);
                this._UserID = value;
                this.OnUserIDChanged();
                this.OnPropertyChanged("UserID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private int _UserID;
        partial void OnUserIDChanging(int value);
        partial void OnUserIDChanged();
        /// <summary>
        /// There are no comments for Property Date in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Date")]
        public global::System.DateTimeOffset Date
        {
            get
            {
                return this._Date;
            }
            set
            {
                this.OnDateChanging(value);
                this._Date = value;
                this.OnDateChanged();
                this.OnPropertyChanged("Date");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.DateTimeOffset _Date;
        partial void OnDateChanging(global::System.DateTimeOffset value);
        partial void OnDateChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::Client.ReviewServices.Library.Review as global::Client.ReviewServices.Library.ReviewSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Client.ReviewServices.Library.ReviewSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Client.ReviewServices.Library.Review> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Client.ReviewServices.Library.ReviewSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Client.ReviewServices.Library.Review as global::Client.ReviewServices.Library.ReviewSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="reviewID">The value of reviewID</param>
        public static global::Client.ReviewServices.Library.ReviewSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Client.ReviewServices.Library.Review> source,
            int reviewID)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "ReviewID", reviewID }
            };
            return new global::Client.ReviewServices.Library.ReviewSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
    }
}
namespace Client.ReviewServices.Default
{
    /// <summary>
    /// There are no comments for Container in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("Container")]
    public partial class Container : global::Microsoft.OData.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new Container object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public Container(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion.V4)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "Default", "Client.ReviewServices.Default");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            resolvedType = this.DefaultResolveType(typeName, "Library", "Client.ReviewServices.Library");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            global::Microsoft.OData.Client.OriginalNameAttribute originalNameAttribute = (global::Microsoft.OData.Client.OriginalNameAttribute)global::System.Linq.Enumerable.SingleOrDefault(global::Microsoft.OData.Client.Utility.GetCustomAttributes(clientType, typeof(global::Microsoft.OData.Client.OriginalNameAttribute), true));
            if (clientType.Namespace.Equals("Client.ReviewServices.Default", global::System.StringComparison.Ordinal))
            {
                if (originalNameAttribute != null)
                {
                    return string.Concat("Default.", originalNameAttribute.OriginalName);
                }
                return string.Concat("Default.", clientType.Name);
            }
            if (clientType.Namespace.Equals("Client.ReviewServices.Library", global::System.StringComparison.Ordinal))
            {
                if (originalNameAttribute != null)
                {
                    return string.Concat("Library.", originalNameAttribute.OriginalName);
                }
                return string.Concat("Library.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Reviews in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Reviews")]
        public global::Microsoft.OData.Client.DataServiceQuery<global::Client.ReviewServices.Library.Review> Reviews
        {
            get
            {
                if ((this._Reviews == null))
                {
                    this._Reviews = base.CreateQuery<global::Client.ReviewServices.Library.Review>("Reviews");
                }
                return this._Reviews;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Client.ReviewServices.Library.Review> _Reviews;
        /// <summary>
        /// There are no comments for Reviews in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public void AddToReviews(global::Client.ReviewServices.Library.Review review)
        {
            base.AddObject("Reviews", review);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::Microsoft.OData.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private const string Edmx = @"<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Library"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""Review"">
        <Key>
          <PropertyRef Name=""ReviewID"" />
        </Key>
        <Property Name=""ReviewID"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Content"" Type=""Edm.String"" />
        <Property Name=""Note"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""MovieID"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""UserID"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Date"" Type=""Edm.DateTimeOffset"" Nullable=""false"" />
      </EntityType>
    </Schema>
    <Schema Namespace=""Default"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <Function Name=""AverageNote"">
        <Parameter Name=""MovieID"" Type=""Edm.Int32"" Nullable=""false"" />
        <ReturnType Type=""Edm.Double"" Nullable=""false"" />
      </Function>
      <EntityContainer Name=""Container"">
        <EntitySet Name=""Reviews"" EntityType=""Library.Review"" />
        <FunctionImport Name=""AverageNote"" Function=""Default.AverageNote"" IncludeInServiceDocument=""true"" />
      </EntityContainer>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            public static global::Microsoft.OData.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::Microsoft.OData.Edm.IEdmModel LoadModelFromString()
            {
                global::System.Xml.XmlReader reader = CreateXmlReader(Edmx);
                try
                {
                    return global::Microsoft.OData.Edm.Csdl.EdmxReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
        /// <summary>
        /// There are no comments for AverageNote in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("AverageNote")]
        public global::Microsoft.OData.Client.DataServiceQuerySingle<double> AverageNote(int MovieID)
        {
            return this.CreateFunctionQuerySingle<double>("", "AverageNote", false, new global::Microsoft.OData.Client.UriOperationParameter("MovieID", MovieID));
        }
    }
}
