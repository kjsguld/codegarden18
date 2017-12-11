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

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Presentation</summary>
	[PublishedContentModel("presentation")]
	public partial class Presentation : PublishedContentModel, IHeadlineBodytext, IMenu, IMeta
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "presentation";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Presentation(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Presentation, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// EndTime
		///</summary>
		[ImplementPropertyType("endTime")]
		public DateTime EndTime
		{
			get { return this.GetPropertyValue<DateTime>("endTime"); }
		}

		///<summary>
		/// Is Workshop
		///</summary>
		[ImplementPropertyType("isWorkshop")]
		public bool IsWorkshop
		{
			get { return this.GetPropertyValue<bool>("isWorkshop"); }
		}

		///<summary>
		/// Room
		///</summary>
		[ImplementPropertyType("room")]
		public IEnumerable<IPublishedContent> Room
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("room"); }
		}

		///<summary>
		/// Speaker
		///</summary>
		[ImplementPropertyType("speaker")]
		public IEnumerable<IPublishedContent> Speaker
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("speaker"); }
		}

		///<summary>
		/// StartTime
		///</summary>
		[ImplementPropertyType("startTime")]
		public DateTime StartTime
		{
			get { return this.GetPropertyValue<DateTime>("startTime"); }
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
}
