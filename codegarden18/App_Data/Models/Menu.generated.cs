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
}