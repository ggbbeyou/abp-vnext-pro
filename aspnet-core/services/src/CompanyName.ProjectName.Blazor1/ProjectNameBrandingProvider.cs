﻿using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CompanyName.ProjectName.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class ProjectNameBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ProjectName";
    }
}