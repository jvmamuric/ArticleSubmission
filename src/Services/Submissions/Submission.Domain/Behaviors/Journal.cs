using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Articles.Abstractions.Enums;
using Submission.Domain;

namespace Submission.Domain.Entities;

//for behaviors
public partial class Journal
{
    public void CreateArticle(string title, ArticleType type, string scope)
    {
        _articles.Add(new Article
        {
            Title = title,
            Scope = scope,
            Type = type,
            Stage = ArticleStage.Created,
            Journal = this
        });

        //add the domain event 
    }
}
