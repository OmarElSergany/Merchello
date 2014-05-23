﻿using System;
using Merchello.Core.Services;
using Merchello.Core.Triggers;

namespace Merchello.Tests.IntegrationTests.ObjectResolution
{
    [TriggerFor("4D749925-3485-4E3E-A2B4-488B4F0A6BC7", "Mock Trigger", "Testing", typeof(InvoiceService), "Creating")]
    internal class MockJohnTrigger : TriggerBase
    {
        public override void Invoke(object sender, EventArgs e)
        {
            Console.WriteLine("Hi John");
        }
    }

}