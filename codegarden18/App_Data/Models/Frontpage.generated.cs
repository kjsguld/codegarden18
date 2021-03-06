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
		/// Body text 2
		///</summary>
		[ImplementPropertyType("bodyText2")]
		public IHtmlString BodyText2
		{
			get { return this.GetPropertyValue<IHtmlString>("bodyText2"); }
		}

		///<summary>
		/// Call to action link: ADD LINK HERE
		///</summary>
		[ImplementPropertyType("callToActionLink")]
		public string CallToActionLink
		{
			get { return this.GetPropertyValue<string>("callToActionLink"); }
		}

		///<summary>
		/// Call to action text: Add link text Here!
		///</summary>
		[ImplementPropertyType("callToActionText")]
		public string CallToActionText
		{
			get { return this.GetPropertyValue<string>("callToActionText"); }
		}

		///<summary>
		/// Company Name
		///</summary>
		[ImplementPropertyType("companyName")]
		public string CompanyName
		{
			get { return this.GetPropertyValue<string>("companyName"); }
		}

		///<summary>
		/// Countdown Date
		///</summary>
		[ImplementPropertyType("countdownDate")]
		public DateTime CountdownDate
		{
			get { return this.GetPropertyValue<DateTime>("countdownDate"); }
		}

		///<summary>
		/// Headline2
		///</summary>
		[ImplementPropertyType("headline2")]
		public string Headline2
		{
			get { return this.GetPropertyValue<string>("headline2"); }
		}

		///<summary>
		/// Logo image
		///</summary>
		[ImplementPropertyType("logoImage")]
		public IPublishedContent LogoImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("logoImage"); }
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
