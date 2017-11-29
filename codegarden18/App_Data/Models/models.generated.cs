//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "5b083e25ab698f7b")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]

namespace Umbraco.Web.PublishedContentModels
{
	// Mixin content Type 1059 with alias "headlineBodytext"
	/// <summary>Headline bodytext</summary>
	public partial interface IHeadlineBodytext : IPublishedContent
	{
		/// <summary>Bodytext</summary>
		IHtmlString Bodytext { get; }

		/// <summary>Headline</summary>
		string Headline { get; }
	}

	/// <summary>Headline bodytext</summary>
	[PublishedContentModel("headlineBodytext")]
	public partial class HeadlineBodytext : PublishedContentModel, IHeadlineBodytext
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "headlineBodytext";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public HeadlineBodytext(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HeadlineBodytext, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Bodytext
		///</summary>
		[ImplementPropertyType("bodytext")]
		public IHtmlString Bodytext
		{
			get { return GetBodytext(this); }
		}

		/// <summary>Static getter for Bodytext</summary>
		public static IHtmlString GetBodytext(IHeadlineBodytext that) { return that.GetPropertyValue<IHtmlString>("bodytext"); }

		///<summary>
		/// Headline
		///</summary>
		[ImplementPropertyType("headline")]
		public string Headline
		{
			get { return GetHeadline(this); }
		}

		/// <summary>Static getter for Headline</summary>
		public static string GetHeadline(IHeadlineBodytext that) { return that.GetPropertyValue<string>("headline"); }
	}

	// Mixin content Type 1060 with alias "menu"
	/// <summary>Menu</summary>
	public partial interface IMenu : IPublishedContent
	{
		/// <summary>Hide in Navigation</summary>
		bool HideInNav { get; }

		/// <summary>Menudesription</summary>
		string Menudesription { get; }

		/// <summary>Menu title</summary>
		string MenuTitle { get; }
	}

	/// <summary>Menu</summary>
	[PublishedContentModel("menu")]
	public partial class Menu : PublishedContentModel, IMenu
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "menu";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Menu(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Menu, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide in Navigation
		///</summary>
		[ImplementPropertyType("hideInNav")]
		public bool HideInNav
		{
			get { return GetHideInNav(this); }
		}

		/// <summary>Static getter for Hide in Navigation</summary>
		public static bool GetHideInNav(IMenu that) { return that.GetPropertyValue<bool>("hideInNav"); }

		///<summary>
		/// Menudesription
		///</summary>
		[ImplementPropertyType("menudesription")]
		public string Menudesription
		{
			get { return GetMenudesription(this); }
		}

		/// <summary>Static getter for Menudesription</summary>
		public static string GetMenudesription(IMenu that) { return that.GetPropertyValue<string>("menudesription"); }

		///<summary>
		/// Menu title
		///</summary>
		[ImplementPropertyType("menuTitle")]
		public string MenuTitle
		{
			get { return GetMenuTitle(this); }
		}

		/// <summary>Static getter for Menu title</summary>
		public static string GetMenuTitle(IMenu that) { return that.GetPropertyValue<string>("menuTitle"); }
	}

	// Mixin content Type 1061 with alias "meta"
	/// <summary>Meta</summary>
	public partial interface IMeta : IPublishedContent
	{
		/// <summary>Meta description</summary>
		string MetaDescription { get; }

		/// <summary>Meta title</summary>
		string MetaTitle { get; }
	}

	/// <summary>Meta</summary>
	[PublishedContentModel("meta")]
	public partial class Meta : PublishedContentModel, IMeta
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "meta";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Meta(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Meta, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Meta description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return GetMetaDescription(this); }
		}

		/// <summary>Static getter for Meta description</summary>
		public static string GetMetaDescription(IMeta that) { return that.GetPropertyValue<string>("metaDescription"); }

		///<summary>
		/// Meta title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return GetMetaTitle(this); }
		}

		/// <summary>Static getter for Meta title</summary>
		public static string GetMetaTitle(IMeta that) { return that.GetPropertyValue<string>("metaTitle"); }
	}

	/// <summary>Awards</summary>
	[PublishedContentModel("awards")]
	public partial class Awards : PublishedContentModel, IHeadlineBodytext, IMenu, IMeta
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "awards";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Awards(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Awards, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Bodytext
		///</summary>
		[ImplementPropertyType("bodytext")]
		public IHtmlString Bodytext
		{
			get { return Umbraco.Web.PublishedContentModels.HeadlineBodytext.GetBodytext(this); }
		}

		///<summary>
		/// Headline
		///</summary>
		[ImplementPropertyType("headline")]
		public string Headline
		{
			get { return Umbraco.Web.PublishedContentModels.HeadlineBodytext.GetHeadline(this); }
		}

		///<summary>
		/// Hide in Navigation
		///</summary>
		[ImplementPropertyType("hideInNav")]
		public bool HideInNav
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetHideInNav(this); }
		}

		///<summary>
		/// Menudesription
		///</summary>
		[ImplementPropertyType("menudesription")]
		public string Menudesription
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetMenudesription(this); }
		}

		///<summary>
		/// Menu title
		///</summary>
		[ImplementPropertyType("menuTitle")]
		public string MenuTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetMenuTitle(this); }
		}

		///<summary>
		/// Meta description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.Meta.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Meta.GetMetaTitle(this); }
		}
	}

	/// <summary>Feed</summary>
	[PublishedContentModel("feed")]
	public partial class Feed : PublishedContentModel, IHeadlineBodytext, IMenu, IMeta
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "feed";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Feed(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Feed, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Bodytext
		///</summary>
		[ImplementPropertyType("bodytext")]
		public IHtmlString Bodytext
		{
			get { return Umbraco.Web.PublishedContentModels.HeadlineBodytext.GetBodytext(this); }
		}

		///<summary>
		/// Headline
		///</summary>
		[ImplementPropertyType("headline")]
		public string Headline
		{
			get { return Umbraco.Web.PublishedContentModels.HeadlineBodytext.GetHeadline(this); }
		}

		///<summary>
		/// Hide in Navigation
		///</summary>
		[ImplementPropertyType("hideInNav")]
		public bool HideInNav
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetHideInNav(this); }
		}

		///<summary>
		/// Menudesription
		///</summary>
		[ImplementPropertyType("menudesription")]
		public string Menudesription
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetMenudesription(this); }
		}

		///<summary>
		/// Menu title
		///</summary>
		[ImplementPropertyType("menuTitle")]
		public string MenuTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetMenuTitle(this); }
		}

		///<summary>
		/// Meta description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.Meta.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Meta.GetMetaTitle(this); }
		}
	}

	/// <summary>Frontpage</summary>
	[PublishedContentModel("frontpage")]
	public partial class Frontpage : PublishedContentModel, IHeadlineBodytext, IMenu, IMeta
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "frontpage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Frontpage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Frontpage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Bodytext
		///</summary>
		[ImplementPropertyType("bodytext")]
		public IHtmlString Bodytext
		{
			get { return Umbraco.Web.PublishedContentModels.HeadlineBodytext.GetBodytext(this); }
		}

		///<summary>
		/// Headline
		///</summary>
		[ImplementPropertyType("headline")]
		public string Headline
		{
			get { return Umbraco.Web.PublishedContentModels.HeadlineBodytext.GetHeadline(this); }
		}

		///<summary>
		/// Hide in Navigation
		///</summary>
		[ImplementPropertyType("hideInNav")]
		public bool HideInNav
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetHideInNav(this); }
		}

		///<summary>
		/// Menudesription
		///</summary>
		[ImplementPropertyType("menudesription")]
		public string Menudesription
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetMenudesription(this); }
		}

		///<summary>
		/// Menu title
		///</summary>
		[ImplementPropertyType("menuTitle")]
		public string MenuTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetMenuTitle(this); }
		}

		///<summary>
		/// Meta description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.Meta.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Meta.GetMetaTitle(this); }
		}
	}

	/// <summary>Odense life</summary>
	[PublishedContentModel("odenseLife")]
	public partial class OdenseLife : PublishedContentModel, IHeadlineBodytext, IMenu, IMeta
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "odenseLife";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public OdenseLife(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<OdenseLife, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Bodytext
		///</summary>
		[ImplementPropertyType("bodytext")]
		public IHtmlString Bodytext
		{
			get { return Umbraco.Web.PublishedContentModels.HeadlineBodytext.GetBodytext(this); }
		}

		///<summary>
		/// Headline
		///</summary>
		[ImplementPropertyType("headline")]
		public string Headline
		{
			get { return Umbraco.Web.PublishedContentModels.HeadlineBodytext.GetHeadline(this); }
		}

		///<summary>
		/// Hide in Navigation
		///</summary>
		[ImplementPropertyType("hideInNav")]
		public bool HideInNav
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetHideInNav(this); }
		}

		///<summary>
		/// Menudesription
		///</summary>
		[ImplementPropertyType("menudesription")]
		public string Menudesription
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetMenudesription(this); }
		}

		///<summary>
		/// Menu title
		///</summary>
		[ImplementPropertyType("menuTitle")]
		public string MenuTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetMenuTitle(this); }
		}

		///<summary>
		/// Meta description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.Meta.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Meta.GetMetaTitle(this); }
		}
	}

	/// <summary>Schedule</summary>
	[PublishedContentModel("schedule")]
	public partial class Schedule : PublishedContentModel, IHeadlineBodytext, IMenu, IMeta
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "schedule";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Schedule(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Schedule, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Bodytext
		///</summary>
		[ImplementPropertyType("bodytext")]
		public IHtmlString Bodytext
		{
			get { return Umbraco.Web.PublishedContentModels.HeadlineBodytext.GetBodytext(this); }
		}

		///<summary>
		/// Headline
		///</summary>
		[ImplementPropertyType("headline")]
		public string Headline
		{
			get { return Umbraco.Web.PublishedContentModels.HeadlineBodytext.GetHeadline(this); }
		}

		///<summary>
		/// Hide in Navigation
		///</summary>
		[ImplementPropertyType("hideInNav")]
		public bool HideInNav
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetHideInNav(this); }
		}

		///<summary>
		/// Menudesription
		///</summary>
		[ImplementPropertyType("menudesription")]
		public string Menudesription
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetMenudesription(this); }
		}

		///<summary>
		/// Menu title
		///</summary>
		[ImplementPropertyType("menuTitle")]
		public string MenuTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetMenuTitle(this); }
		}

		///<summary>
		/// Meta description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.Meta.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Meta.GetMetaTitle(this); }
		}
	}

	/// <summary>Speakers</summary>
	[PublishedContentModel("speakers")]
	public partial class Speakers : PublishedContentModel, IHeadlineBodytext, IMenu, IMeta
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "speakers";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Speakers(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Speakers, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Bodytext
		///</summary>
		[ImplementPropertyType("bodytext")]
		public IHtmlString Bodytext
		{
			get { return Umbraco.Web.PublishedContentModels.HeadlineBodytext.GetBodytext(this); }
		}

		///<summary>
		/// Headline
		///</summary>
		[ImplementPropertyType("headline")]
		public string Headline
		{
			get { return Umbraco.Web.PublishedContentModels.HeadlineBodytext.GetHeadline(this); }
		}

		///<summary>
		/// Hide in Navigation
		///</summary>
		[ImplementPropertyType("hideInNav")]
		public bool HideInNav
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetHideInNav(this); }
		}

		///<summary>
		/// Menudesription
		///</summary>
		[ImplementPropertyType("menudesription")]
		public string Menudesription
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetMenudesription(this); }
		}

		///<summary>
		/// Menu title
		///</summary>
		[ImplementPropertyType("menuTitle")]
		public string MenuTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetMenuTitle(this); }
		}

		///<summary>
		/// Meta description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.Meta.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Meta.GetMetaTitle(this); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}