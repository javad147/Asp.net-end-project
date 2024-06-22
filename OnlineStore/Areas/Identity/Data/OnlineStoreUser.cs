﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OnlineStore.Areas.Identity.Data;

// Add profile data for application users by adding properties to the OnlineStoreUser class
public class OnlineStoreUser : IdentityUser
{
    public string FullName { get; set; }
}

