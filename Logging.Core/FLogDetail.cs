using System;
using System.Collections.Generic;

namespace Logging.Core
{
  public class FlogDetail
  {
    public FlogDetail()
    {
      Timestamp = DateTime.Now;
    }

    public DateTime Timestamp { get; }

    public string Message { get; set; }

    // WHERE

    public string Product { get; set; }
    public string Layer { get; set; }
    public string Location { get; set; }
    public string Hostname { get; set; }

    // WHO

    public string UserId { get; set; }
    public string UserName { get; set; }
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }

    // EVERYTHING ELSE

    public long? ElapsedMillisceconds { get; set; } // only for performance entries
    public Exception Exception { get; set; } // the exception error
    public string CorrelationId { get; set; } // exception shielding from server to client
    public Dictionary<string, object> Dictionary { get; set; } // catch-all for anything else
  }
}
