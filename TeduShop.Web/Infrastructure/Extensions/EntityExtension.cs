using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Infrastructure.Extensions
{
    public static class EntityExtension
    {
        public static void UpdatePostCategory(this PostCategory postCategory,
            PostCategoryViewModel postCategoryVm)
        {
            postCategory.ID = postCategoryVm.ID;
            postCategory.Name = postCategoryVm.Name;
            postCategory.Description = postCategoryVm.Description;
            postCategory.Alias = postCategoryVm.Alias;
            postCategory.ParentID = postCategoryVm.ParentID;
            postCategory.DisplayOrder = postCategoryVm.DisplayOrder;
            postCategory.Image = postCategoryVm.Image;
            postCategory.HomeFlag = postCategoryVm.HomeFlag;
            postCategory.CreatedBy = postCategoryVm.CreatedBy;
            postCategory.CreatedDate = postCategoryVm.CreatedDate;
            postCategory.UpdatedBy = postCategoryVm.UpdatedBy;
            postCategory.UpdatedDate = postCategoryVm.UpdatedDate;
            postCategory.MetaDescription = postCategoryVm.MetaDescription;
            postCategory.MetaKeyword = postCategoryVm.MetaKeyword;
            postCategory.Status = postCategoryVm.Status;
        }

        public static void UpdatePost(this Post post,
            PostViewModel postVm)
        {
            post.ID = postVm.ID;
            post.Name = postVm.Name;
            post.Description = postVm.Description;
            post.Alias = postVm.Alias;
            post.CategoryID = postVm.CategoryID;
            post.Content = postVm.Content;
            post.Image = postVm.Image;
            post.HomeFlag = postVm.HomeFlag;
            post.ViewCount = postVm.ViewCount;
            post.HotFlag = postVm.HotFlag;
            post.CreatedBy = postVm.CreatedBy;
            post.CreatedDate = postVm.CreatedDate;
            post.UpdatedBy = postVm.UpdatedBy;
            post.UpdatedDate = postVm.UpdatedDate;
            post.MetaDescription = postVm.MetaDescription;
            post.MetaKeyword = postVm.MetaKeyword;
            post.Status = postVm.Status;
        }
    }
}