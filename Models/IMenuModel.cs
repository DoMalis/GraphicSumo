using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoMVC.Models
{
    public interface IMenuModel
    {
        string[] Options { get; set; }
         int SelectedIndex { get; set; }
        string Prompt { get; set; }

    }
}
