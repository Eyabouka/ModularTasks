using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularTasks.Core.Entities
{
    namespace ModularTasks.Core.Entities
    {
        public record TaskItem(Guid Id, string Title, DateTime DueDate, bool IsCompleted);
    }
}
