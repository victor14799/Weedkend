using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Weedkend
{
    public class OrderSuccessModel : PageModel
    {
        public void OnGet()
        {
            byte[] gb = Guid.NewGuid().ToByteArray();
            long l = BitConverter.ToInt64(gb, 0);
        }
    }
}