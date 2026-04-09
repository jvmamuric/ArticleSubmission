using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Articles.Abstractions;
using Articles.Abstractions.Enums;
using FluentValidation;
using MediatR;

namespace Submission.Application.Features.CreateArticle;

public record CreateArticleCommand(int JournalId, string Title, string Scope, ArticleType ArticleType) : IRequest<IdResponse>;



public class CreateArticleValidator : AbstractValidator<CreateArticleCommand>
{
    public CreateArticleValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Title must not be empty");

        RuleFor(x => x.Scope)
            .NotEmpty().WithMessage("Scope cannot be empty");
        RuleFor(x => x.JournalId)

            .GreaterThan(0).WithMessage("Invalid journal id");
    }
}


internal record CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand, IdResponse>
{
    public async Task<IdResponse> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}