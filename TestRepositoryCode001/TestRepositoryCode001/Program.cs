// See https://aka.ms/new-console-template for more information
using TestRepositoryCode001;

string str = "Hello, World!";


List<ITestRepoOutput> tester =
[
	new TestChildDependency1(),
	new TestChildDependency2(),
	new TestChildDependency3(),
	new TestChildDependency4(),
	new TestChildDependency5()
];

tester.ForEach(test => test.Output(str));
