using tmp.Application.Common.Interfaces;
using System;

namespace tmp.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
