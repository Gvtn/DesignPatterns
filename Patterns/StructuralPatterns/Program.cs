using StructuralPatterns.Adapter;
using StructuralPatterns.Facade;
using Utility;

// P R O X Y

ProxyStartExamples.ProxyToExternalSystemRun();

ConsoleDecoration.AddDecoration("Proxy with lazy loading example",
                                () => ProxyStartExamples.LazyLoadingProxyRun());

// A D A P T E R

ConsoleDecoration.AddDecoration("Adapter Of Object example",
                                () => AdapterUseExamples.AdapterOfObjectRun());

// F A C A D E

ConsoleDecoration.AddDecoration("Facade With Two Subsystems example",
                                () => FacadeUseExamples.FacadeWithTwoSubsystemsRun());