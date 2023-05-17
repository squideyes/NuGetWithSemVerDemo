**THE ASK**: 

Create a GitHub action that deploys the **MiscHelpers** project to NuGet whenever a change is checked in to the "master" branch of the <a href="https://github.com/squideyes/NuGetWithSemVerDemo" target="_blank">NuGetWithSemVerDemo</a> repo.

* Be sure to automatically update the SemVer 2.0 version with each commit (see <a href="https://gitversion.net/docs/" target="_blank">https://gitversion.net/docs/</a> or <a href="https://github.com/thefringeninja/action-minver" target="_blank">https://github.com/thefringeninja/action-minver</a> for details, but feel free to use a different library or technique if you prefer).
* The **Demo** project should be compiled but not be published.
* The **UnitTests** project should be run as part of the build but not be published.

The ultimate deliverable will be a GitHub Action **Publish.yml** file and a **set of instructions/walkthrough** that shows a developer how to publish a NuGet.


