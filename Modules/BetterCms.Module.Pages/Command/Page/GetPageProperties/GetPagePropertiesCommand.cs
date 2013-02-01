﻿using System;
using System.Linq;

using BetterCms.Core.Mvc.Commands;
using BetterCms.Module.MediaManager.ViewModels;
using BetterCms.Module.Pages.Models;
using BetterCms.Module.Pages.Services;
using BetterCms.Module.Pages.ViewModels.Page;
using BetterCms.Module.Root.Mvc;

namespace BetterCms.Module.Pages.Command.Page.GetPageProperties
{
    /// <summary>
    /// Command for getting view model with page properties
    /// </summary>
    public class GetPagePropertiesCommand : CommandBase, ICommand<Guid, EditPagePropertiesViewModel>
    {
        /// <summary>
        /// The category service
        /// </summary>
        private ICategoryService categoryService;

        /// <summary>
        /// The tag service
        /// </summary>
        private readonly ITagService tagService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPagePropertiesCommand" /> class.
        /// </summary>
        /// <param name="tagService">The tag service.</param>
        /// <param name="categoryService">The category service.</param>
        public GetPagePropertiesCommand(ITagService tagService, ICategoryService categoryService)
        {
            this.tagService = tagService;
            this.categoryService = categoryService;
        }

        /// <summary>
        /// Executes the specified request.
        /// </summary>
        /// <param name="id">The page id.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public EditPagePropertiesViewModel Execute(Guid id)
        {
            EditPagePropertiesViewModel model;

            model = Repository
                .AsQueryable<PageProperties>()
                .Where(p => p.Id == id)
                .Select(page => new EditPagePropertiesViewModel
                            {
                                Id = page.Id,
                                Version = page.Version,
                                PageName = page.Title,
                                PageUrl = page.PageUrl,
                                PageCSS = page.CustomCss,
                                PageJavascript = page.CustomJS,
                                UseNoFollow = page.UseNoFollow,
                                UseNoIndex = page.UseNoIndex,
                                IsVisibleToEveryone = page.IsPublic,
                                TemplateId = page.Layout.Id,
                                CategoryId = page.Category.Id,
                                Image = new ImageSelectorViewModel
                                            {
                                                ImageId = page.Image.Id,
                                                ImageVersion = page.Image.Version,
                                                ImageUrl = page.Image.PublicUrl,
                                                ThumbnailUrl = page.Image.PublicThumbnailUrl,
                                                ImageTooltip = page.Image.Caption
                                            }
                            })
                .FirstOrDefault();

            if (model != null)
            {
                model.Tags = tagService.GetPageTagNames(id);
                model.RedirectFromOldUrl = true;
            }
            else
            {
                model = new EditPagePropertiesViewModel();
            }

            model.Categories = categoryService.GetCategories();

            return model;
        }
    }
}