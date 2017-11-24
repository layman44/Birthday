using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday.EmailSendConfig
{
    public class EmailSendConfig : Entity<Guid>, IHasCreationTime, IHasModificationTime
    {
        public DateTime CreationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime? LastModificationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
