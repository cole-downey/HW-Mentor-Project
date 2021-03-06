﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mentor_Project_1.Data.Models;

namespace Mentor_Project_1.Data.DTOs
{
    public class GetBlogResponse : BlogResponse
    {
        public GetBlogResponse() {}

        public GetBlogResponse(Blog blog) : base(blog)
        {
            GeneratePostResponses(blog.Posts);
        }
        public List<PostResponse> Posts { get; } = new List<PostResponse>();

        private void GeneratePostResponses(List<Post> realPosts)
        {   
            foreach (var post in realPosts)
            {
                Posts.Add(new PostResponse(post));
            }
        }
    }
}
