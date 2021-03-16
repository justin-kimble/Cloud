using System;
using Octokit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Core.Controllers
{
    public class GithubHelper
    {
        public static IReadOnlyList<Repository> GetRepositories(string organization)
        {
            var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            return client.Repository.GetAllForOrg(organization).Result;
        }
    }
}
