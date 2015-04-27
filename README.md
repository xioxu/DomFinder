# DomFinder
A Dom finder with chained expression

[Telerik] provides an excellent automatic test tool "TestStudio", and it also provides a wonderful test framework.
I'm very like its Dom Element explore API, but it depends on a real browser,so I did a little of wrapper to supports html string, with this, we can do web site craw easily£¬ high performance.  

# Sample Usage
    
     var table = new DomFinder(htmlContent).Find.ByExpression<HtmlTable>("id=rtp2");
     if (table != null)
        {
            foreach (var row in table.BodyRows)
            {
                    foreach (var cell in row.Cells)
                    {
                        Console.Write(cell.InnerText + "   ");
                    }
            }

                Console.WriteLine("\r\n-------------------------------");
        }

# More API
Since domFinder is just a wrapper of test studio framework, so its api is also suiteble for DomFinder.

+ [Resource 1](http://docs.telerik.com/teststudio/testing-framework/write-tests-in-code/intermediate-topics-wtc/element-identification-wtc/find-expressions)
+ [Resource 2](http://docs.telerik.com/teststudio/testing-framework/write-tests-in-code/intermediate-topics-wtc/element-identification-wtc/finding-page-elements)



[Telerik]:http://www.telerik.com/
