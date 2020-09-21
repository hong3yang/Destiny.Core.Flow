﻿using Destiny.Core.Flow.Model.IdentityServer4;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Destiny.Core.Flow.Model.EntityConfigurations.IdentityServer4.Clients
{
    public class ClientPostLogoutRedirectUriConfiguration : EntityMappingConfiguration<ClientPostLogoutRedirectUri, Guid>
    {
        public override void Map(EntityTypeBuilder<ClientPostLogoutRedirectUri> b)
        {
            b.HasKey(o => o.Id);
            b.ToTable("ClientPostLogoutRedirectUri");
        }
    }
}