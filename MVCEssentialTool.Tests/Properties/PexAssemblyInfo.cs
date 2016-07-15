// <copyright file="PexAssemblyInfo.cs">Copyright ©  2016</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("MVCEssentialTool")]
[assembly: PexInstrumentAssembly("Ninject.Web.Common")]
[assembly: PexInstrumentAssembly("System.Core")]
[assembly: PexInstrumentAssembly("Microsoft.Web.Infrastructure")]
[assembly: PexInstrumentAssembly("Ninject")]
[assembly: PexInstrumentAssembly("WebActivator")]
[assembly: PexInstrumentAssembly("System.Web")]
[assembly: PexInstrumentAssembly("System.Web.Mvc")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Ninject.Web.Common")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.Web.Infrastructure")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Ninject")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "WebActivator")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Web")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Web.Mvc")]

