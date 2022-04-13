using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTutor
{
    internal interface iMenu
    {
        string GetType();
        void ShowMenu();
        string SelectMenu();
    }
}
