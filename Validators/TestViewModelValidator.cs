using System;
using System.Collections.Generic;
using FluentValidation;
using GitHubIssue.Models;
using Microsoft.Extensions.Logging;

namespace GitHubIssue.Validators
{
    public class TestViewModelsValidator : AbstractValidator<List<TestViewModel>>
    {
        public TestViewModelsValidator(TestViewModelValidator testViewModelValidator)
        {
            RuleForEach(x => x)
                .SetValidator(testViewModelValidator);
        }
    }

    public class TestViewModelValidator : AbstractValidator<TestViewModel>
    {
        public TestViewModelValidator(ILogger<TestViewModelValidator> logger)
        {
            logger.LogDebug("TEST");

            RuleFor(x => x.Id)
                .NotEmpty();
        }
    }
}