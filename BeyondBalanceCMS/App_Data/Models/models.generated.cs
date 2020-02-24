//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
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
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "1e87f5d91b7b7a0f")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.3")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>HomePage</summary>
	[PublishedContentModel("homePage")]
	public partial class HomePage : PublishedContentModel, ITitleSeo
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "homePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public HomePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description Metadata: Text used by search engines to index pages
		///</summary>
		[ImplementPropertyType("descriptionMetadata")]
		public string DescriptionMetadata
		{
			get { return Umbraco.Web.PublishedContentModels.TitleSeo.GetDescriptionMetadata(this); }
		}

		///<summary>
		/// Page Title: Title that appears on Browser bar
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.TitleSeo.GetPageTitle(this); }
		}
	}

	// Mixin content Type 1068 with alias "titleSEO"
	/// <summary>_Title&SEO</summary>
	public partial interface ITitleSeo : IPublishedContent
	{
		/// <summary>Description Metadata</summary>
		string DescriptionMetadata { get; }

		/// <summary>Page Title</summary>
		string PageTitle { get; }
	}

	/// <summary>_Title&SEO</summary>
	[PublishedContentModel("titleSEO")]
	public partial class TitleSeo : PublishedContentModel, ITitleSeo
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "titleSEO";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TitleSeo(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TitleSeo, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description Metadata: Text used by search engines to index pages
		///</summary>
		[ImplementPropertyType("descriptionMetadata")]
		public string DescriptionMetadata
		{
			get { return GetDescriptionMetadata(this); }
		}

		/// <summary>Static getter for Description Metadata</summary>
		public static string GetDescriptionMetadata(ITitleSeo that) { return that.GetPropertyValue<string>("descriptionMetadata"); }

		///<summary>
		/// Page Title: Title that appears on Browser bar
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return GetPageTitle(this); }
		}

		/// <summary>Static getter for Page Title</summary>
		public static string GetPageTitle(ITitleSeo that) { return that.GetPropertyValue<string>("pageTitle"); }
	}

	/// <summary>Training</summary>
	[PublishedContentModel("training")]
	public partial class Training : PublishedContentModel, ITitleSeo
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "training";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Training(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Training, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description Metadata: Text used by search engines to index pages
		///</summary>
		[ImplementPropertyType("descriptionMetadata")]
		public string DescriptionMetadata
		{
			get { return Umbraco.Web.PublishedContentModels.TitleSeo.GetDescriptionMetadata(this); }
		}

		///<summary>
		/// Page Title: Title that appears on Browser bar
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.TitleSeo.GetPageTitle(this); }
		}
	}

	/// <summary>Stress</summary>
	[PublishedContentModel("stress")]
	public partial class Stress : PublishedContentModel, ITitleSeo
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "stress";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Stress(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Stress, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Area2 Column1 Picture
		///</summary>
		[ImplementPropertyType("area2Column1Picture")]
		public IPublishedContent Area2Column1Picture
		{
			get { return this.GetPropertyValue<IPublishedContent>("area2Column1Picture"); }
		}

		///<summary>
		/// Area2 Column1 Text Below Picture
		///</summary>
		[ImplementPropertyType("area2Column1TextBelowPicture")]
		public IHtmlString Area2Column1TextBelowPicture
		{
			get { return this.GetPropertyValue<IHtmlString>("area2Column1TextBelowPicture"); }
		}

		///<summary>
		/// Area2 Column1 Title
		///</summary>
		[ImplementPropertyType("area2Column1Title")]
		public string Area2Column1Title
		{
			get { return this.GetPropertyValue<string>("area2Column1Title"); }
		}

		///<summary>
		/// Area2 Column2 Picture
		///</summary>
		[ImplementPropertyType("area2Column2Picture")]
		public IPublishedContent Area2Column2Picture
		{
			get { return this.GetPropertyValue<IPublishedContent>("area2Column2Picture"); }
		}

		///<summary>
		/// Area2 Column2 Text Below Picture
		///</summary>
		[ImplementPropertyType("area2Column2TextBelowPicture")]
		public IHtmlString Area2Column2TextBelowPicture
		{
			get { return this.GetPropertyValue<IHtmlString>("area2Column2TextBelowPicture"); }
		}

		///<summary>
		/// Area2 Column2 Title
		///</summary>
		[ImplementPropertyType("area2Column2Title")]
		public string Area2Column2Title
		{
			get { return this.GetPropertyValue<string>("area2Column2Title"); }
		}

		///<summary>
		/// Full Width Area1 Content
		///</summary>
		[ImplementPropertyType("fullWidthArea1Content")]
		public IHtmlString FullWidthArea1Content
		{
			get { return this.GetPropertyValue<IHtmlString>("fullWidthArea1Content"); }
		}

		///<summary>
		/// Full Width Area1 Title
		///</summary>
		[ImplementPropertyType("fullWidthArea1Title")]
		public string FullWidthArea1Title
		{
			get { return this.GetPropertyValue<string>("fullWidthArea1Title"); }
		}

		///<summary>
		/// Top Carousel Picture1
		///</summary>
		[ImplementPropertyType("topCarouselPicture1")]
		public IPublishedContent TopCarouselPicture1
		{
			get { return this.GetPropertyValue<IPublishedContent>("topCarouselPicture1"); }
		}

		///<summary>
		/// Top Carousel Picture2
		///</summary>
		[ImplementPropertyType("topCarouselPicture2")]
		public IPublishedContent TopCarouselPicture2
		{
			get { return this.GetPropertyValue<IPublishedContent>("topCarouselPicture2"); }
		}

		///<summary>
		/// Top Carousel Picture3
		///</summary>
		[ImplementPropertyType("topCarouselPicture3")]
		public IPublishedContent TopCarouselPicture3
		{
			get { return this.GetPropertyValue<IPublishedContent>("topCarouselPicture3"); }
		}

		///<summary>
		/// Top Carousel Picture4
		///</summary>
		[ImplementPropertyType("topCarouselPicture4")]
		public IPublishedContent TopCarouselPicture4
		{
			get { return this.GetPropertyValue<IPublishedContent>("topCarouselPicture4"); }
		}

		///<summary>
		/// Top Carousel Picture5
		///</summary>
		[ImplementPropertyType("topCarouselPicture5")]
		public IPublishedContent TopCarouselPicture5
		{
			get { return this.GetPropertyValue<IPublishedContent>("topCarouselPicture5"); }
		}

		///<summary>
		/// Top Mobile Image
		///</summary>
		[ImplementPropertyType("topMobileImage")]
		public IPublishedContent TopMobileImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("topMobileImage"); }
		}

		///<summary>
		/// Description Metadata: Text used by search engines to index pages
		///</summary>
		[ImplementPropertyType("descriptionMetadata")]
		public string DescriptionMetadata
		{
			get { return Umbraco.Web.PublishedContentModels.TitleSeo.GetDescriptionMetadata(this); }
		}

		///<summary>
		/// Page Title: Title that appears on Browser bar
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.TitleSeo.GetPageTitle(this); }
		}
	}

	/// <summary>Corporate</summary>
	[PublishedContentModel("corporate")]
	public partial class Corporate : PublishedContentModel, ITitleSeo
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "corporate";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Corporate(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Corporate, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Area2 Column1 Picture
		///</summary>
		[ImplementPropertyType("area2Column1Picture")]
		public IPublishedContent Area2Column1Picture
		{
			get { return this.GetPropertyValue<IPublishedContent>("area2Column1Picture"); }
		}

		///<summary>
		/// Area2 Column1 Text Below Picture
		///</summary>
		[ImplementPropertyType("area2Column1TextBelowPicture")]
		public IHtmlString Area2Column1TextBelowPicture
		{
			get { return this.GetPropertyValue<IHtmlString>("area2Column1TextBelowPicture"); }
		}

		///<summary>
		/// Area2 Column1 Title
		///</summary>
		[ImplementPropertyType("area2Column1Title")]
		public string Area2Column1Title
		{
			get { return this.GetPropertyValue<string>("area2Column1Title"); }
		}

		///<summary>
		/// Area2 Column2 Picture
		///</summary>
		[ImplementPropertyType("area2Column2Picture")]
		public IPublishedContent Area2Column2Picture
		{
			get { return this.GetPropertyValue<IPublishedContent>("area2Column2Picture"); }
		}

		///<summary>
		/// Area2 Column2 Text Below Picture
		///</summary>
		[ImplementPropertyType("area2Column2TextBelowPicture")]
		public IHtmlString Area2Column2TextBelowPicture
		{
			get { return this.GetPropertyValue<IHtmlString>("area2Column2TextBelowPicture"); }
		}

		///<summary>
		/// Area2 Column2 Title
		///</summary>
		[ImplementPropertyType("area2Column2Title")]
		public string Area2Column2Title
		{
			get { return this.GetPropertyValue<string>("area2Column2Title"); }
		}

		///<summary>
		/// Banner Text
		///</summary>
		[ImplementPropertyType("bannerText")]
		public string BannerText
		{
			get { return this.GetPropertyValue<string>("bannerText"); }
		}

		///<summary>
		/// Full Width Area1 Content
		///</summary>
		[ImplementPropertyType("fullWidthArea1Content")]
		public IHtmlString FullWidthArea1Content
		{
			get { return this.GetPropertyValue<IHtmlString>("fullWidthArea1Content"); }
		}

		///<summary>
		/// Full Width Area1 Title
		///</summary>
		[ImplementPropertyType("fullWidthArea1Title")]
		public string FullWidthArea1Title
		{
			get { return this.GetPropertyValue<string>("fullWidthArea1Title"); }
		}

		///<summary>
		/// Main Desktop Image
		///</summary>
		[ImplementPropertyType("mainDesktopImage")]
		public IPublishedContent MainDesktopImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("mainDesktopImage"); }
		}

		///<summary>
		/// Main Mobile Image
		///</summary>
		[ImplementPropertyType("mainMobileImage")]
		public IPublishedContent MainMobileImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("mainMobileImage"); }
		}

		///<summary>
		/// Description Metadata: Text used by search engines to index pages
		///</summary>
		[ImplementPropertyType("descriptionMetadata")]
		public string DescriptionMetadata
		{
			get { return Umbraco.Web.PublishedContentModels.TitleSeo.GetDescriptionMetadata(this); }
		}

		///<summary>
		/// Page Title: Title that appears on Browser bar
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.TitleSeo.GetPageTitle(this); }
		}
	}

	/// <summary>Nutrition</summary>
	[PublishedContentModel("nutrition")]
	public partial class Nutrition : PublishedContentModel, ITitleSeo
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "nutrition";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Nutrition(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Nutrition, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Banner Text
		///</summary>
		[ImplementPropertyType("bannerText")]
		public string BannerText
		{
			get { return this.GetPropertyValue<string>("bannerText"); }
		}

		///<summary>
		/// Column1 Text Area1
		///</summary>
		[ImplementPropertyType("column1TextArea1")]
		public IHtmlString Column1TextArea1
		{
			get { return this.GetPropertyValue<IHtmlString>("column1TextArea1"); }
		}

		///<summary>
		/// Column2 Picture Area1
		///</summary>
		[ImplementPropertyType("column2PictureArea1")]
		public IPublishedContent Column2PictureArea1
		{
			get { return this.GetPropertyValue<IPublishedContent>("column2PictureArea1"); }
		}

		///<summary>
		/// Full Width Title
		///</summary>
		[ImplementPropertyType("fullWidthTitle")]
		public string FullWidthTitle
		{
			get { return this.GetPropertyValue<string>("fullWidthTitle"); }
		}

		///<summary>
		/// Top Carousel Picture1
		///</summary>
		[ImplementPropertyType("topCarouselPicture1")]
		public IPublishedContent TopCarouselPicture1
		{
			get { return this.GetPropertyValue<IPublishedContent>("topCarouselPicture1"); }
		}

		///<summary>
		/// Top Carousel Picture2
		///</summary>
		[ImplementPropertyType("topCarouselPicture2")]
		public IPublishedContent TopCarouselPicture2
		{
			get { return this.GetPropertyValue<IPublishedContent>("topCarouselPicture2"); }
		}

		///<summary>
		/// Top Carousel Picture3
		///</summary>
		[ImplementPropertyType("topCarouselPicture3")]
		public IPublishedContent TopCarouselPicture3
		{
			get { return this.GetPropertyValue<IPublishedContent>("topCarouselPicture3"); }
		}

		///<summary>
		/// Top Carousel Picture4
		///</summary>
		[ImplementPropertyType("topCarouselPicture4")]
		public IPublishedContent TopCarouselPicture4
		{
			get { return this.GetPropertyValue<IPublishedContent>("topCarouselPicture4"); }
		}

		///<summary>
		/// Top Mobile Image
		///</summary>
		[ImplementPropertyType("topMobileImage")]
		public IPublishedContent TopMobileImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("topMobileImage"); }
		}

		///<summary>
		/// Description Metadata: Text used by search engines to index pages
		///</summary>
		[ImplementPropertyType("descriptionMetadata")]
		public string DescriptionMetadata
		{
			get { return Umbraco.Web.PublishedContentModels.TitleSeo.GetDescriptionMetadata(this); }
		}

		///<summary>
		/// Page Title: Title that appears on Browser bar
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.TitleSeo.GetPageTitle(this); }
		}
	}

	/// <summary>Testimonials Item</summary>
	[PublishedContentModel("testimonialsItem")]
	public partial class TestimonialsItem : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "testimonialsItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TestimonialsItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TestimonialsItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hidden Text
		///</summary>
		[ImplementPropertyType("additionalText")]
		public string AdditionalText
		{
			get { return this.GetPropertyValue<string>("additionalText"); }
		}

		///<summary>
		/// Client Name
		///</summary>
		[ImplementPropertyType("clientName")]
		public string ClientName
		{
			get { return this.GetPropertyValue<string>("clientName"); }
		}

		///<summary>
		/// Main Text
		///</summary>
		[ImplementPropertyType("mainText")]
		public string MainText
		{
			get { return this.GetPropertyValue<string>("mainText"); }
		}

		///<summary>
		/// Hidden Second Paragragh
		///</summary>
		[ImplementPropertyType("moreAdditionalText")]
		public string MoreAdditionalText
		{
			get { return this.GetPropertyValue<string>("moreAdditionalText"); }
		}
	}

	/// <summary>Testimonials Page</summary>
	[PublishedContentModel("testimonialsPage")]
	public partial class TestimonialsPage : PublishedContentModel, ITitleSeo
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "testimonialsPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TestimonialsPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TestimonialsPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description Metadata: Text used by search engines to index pages
		///</summary>
		[ImplementPropertyType("descriptionMetadata")]
		public string DescriptionMetadata
		{
			get { return Umbraco.Web.PublishedContentModels.TitleSeo.GetDescriptionMetadata(this); }
		}

		///<summary>
		/// Page Title: Title that appears on Browser bar
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.TitleSeo.GetPageTitle(this); }
		}
	}

	/// <summary>_Banner</summary>
	[PublishedContentModel("banner")]
	public partial class Banner : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "banner";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Banner(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Banner, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Banner Text
		///</summary>
		[ImplementPropertyType("text")]
		public string Text
		{
			get { return this.GetPropertyValue<string>("text"); }
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
