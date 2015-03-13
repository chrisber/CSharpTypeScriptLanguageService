using System;
using System.IO;
using NUnit.Framework;
using FluentAssertions;


namespace TypeScriptLanguageService.Test
{
	[TestFixture]
    public class LanguageServiceTest
    {
		[Test]
		public void Init_TypeScriptLanguageService()
		{
			var host =  new FakeTypeScriptLanguageServiceHost();
			var tsService = new TypeScriptLanguageServices(host, File.ReadAllText("typescriptServices.js"));
			Action act = () => tsService.GetCompletionsAtPosition("", 1);
				
			act.ShouldThrow<InvalidOperationException>();
			tsService.Should().NotBeNull();
		}
    }
}
	