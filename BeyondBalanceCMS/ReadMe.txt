
MAIN THINGS TO REMEMBER WITH UMBRACO

1 Create a document type 
2 by default a related document is created

To add subpages or subsections

1 go to documentType permissions and add the child node
these can be added as pages through menu or as subsections within the page itself

Refresh your memory here:
https://umbraco.tv/videos/umbraco-v7/

Setting up templates
https://umbraco.tv/videos/umbraco-v7/implementor/fundamentals/templating/setting-up-our-first-template/

DEPLOYMENT
---------------
only publish the files that have been changed to minimize issues going forward


include all hidden files in the media folder and publish !!
include all views and publish

SHOULD GET A SYNC TOOL TO SYNC BOTH ENVIRONMENTS




MAIN THINGS TO REMEMBER OTHERWISE

menu is a hack the healthy recipes page and contact pages use the menu in the master, 
the other pages use the menu in the master page, this is a nasty hack to avoid importing those pages into umbraco and creating an API.

use Visual Studio 2017 or 2019and web compiler to compile the scss this because its not supported in 2022 


-----------------------------------------------------------
UMBRACO CAN BE VERY TRICKY 

several issues arise when page types are not linked to templates correctly and they are not named 
properly
if this happens best to delete and readd, no solution good for now, 
or lookup in models folder try and find the id because the error
ErrorCS0234	The type or namespace name 'ThyroidCourseModule' does not exist in the namespace 'Umbraco.Web.PublishedContentModels' (are you missing an assembly reference?)	5_Views_ThyroidCourseModule.cshtml	C:\Development\Clients\beyondbalanceCMS\BeyondBalanceCMS\BeyondBalanceCMS\Views\ThyroidCourseModule.cshtml	1	Active

Is because the name doesn't match, never been able to fix this. But not really a problem.

