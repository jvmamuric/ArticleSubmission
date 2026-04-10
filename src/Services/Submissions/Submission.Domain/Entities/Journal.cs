using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Submission.Domain;

namespace Submission.Domain.Entities;

public partial class Journal
{
    private readonly List<Article> _articles = new();

    public int Id { get; set; }
    public required string Name { get; set; }
    public string Abbreviation { get; set; }

    public IReadOnlyList<Article> Articles => _articles;
}
