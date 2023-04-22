using OrdSYS.Models.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS.Models.Admin
{
    public class AdminModel : UserModel
    {
        private char _isRoot;

        public char IsRoot { get => _isRoot; set => _isRoot = value; }
    }
}
