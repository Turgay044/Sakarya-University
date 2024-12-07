﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BerberKuafor.Areas.Identity.Data;

// Add profile data for application users by adding properties to the BerberKuaforUser class
public class BerberKuaforUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName = "nvarchar(5)")]
    public string Cinsiyet { get; set; }

}

