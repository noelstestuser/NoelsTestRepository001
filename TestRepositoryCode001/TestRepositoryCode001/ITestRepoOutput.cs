using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepositoryCode001;


public interface ITestRepoOutput
{
	void Output(string str);
}

public class AbstractTestChildDependency(int times) : ITestRepoOutput
{
	public void Output(string str)
	{
		for (int i = 0; i < times; i++)
		{
			Console.WriteLine(str);
		}
	}
}


public class TestChildDependency1() : AbstractTestChildDependency(1) { }
public class TestChildDependency2() : AbstractTestChildDependency(2) { }
public class TestChildDependency3() : AbstractTestChildDependency(3) { }
public class TestChildDependency4() : AbstractTestChildDependency(4) { }
public class TestChildDependency5() : AbstractTestChildDependency(5) { }
