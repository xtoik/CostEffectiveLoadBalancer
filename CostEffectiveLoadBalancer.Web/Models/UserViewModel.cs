using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CostEffectiveLoadBalancer.Web.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public IEnumerable<string> Claims { get; set; }

        public string Token { get; set; }
    }
}