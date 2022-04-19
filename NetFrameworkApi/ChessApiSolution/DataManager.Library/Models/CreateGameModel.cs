using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Library.Models
{
    public class CreateGameModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string BoardData { get; set; }
        public string UserId { get; set; }
    }
}
