Relationships in VS-Mac:
(As described: https://docs.microsoft.com/en-us/visualstudio/mac/projects-and-solutions?view=vsmac-2019)

Project: source-code that contains business logic for an executable, library, or website.

Solution: thet structure that holds related and/or required projects together in one place;
kinda like a folder that houses a bunch of 'projects' that are needed for the program mechanism to 'run'

Solution: CarClassLibrary (master)
Project(s): [ CarClassLibrary, CarStoreConsoleApp, VerificationLibrary ]


helpful Git commands:
command                         (Definition)
git init                        (start local version-control for repo)
git branch                      (To see local branches, run this command)
git branch -r                   (To see remote branches, run this command)
git branch -a                   (To see all local and remote branches, run this command)
git checkout -b /feature123     ('checkout -b' tells the repo to switch to a new branch named '/feature123' )
git rm -r git                   ('rm' command removes folder ; '-r' command removed nested files under the folder named 'git')
git ls-files                    ('ls-files' command list all files in the current directory)


Other helpful notes:
git add -a                      (if a commit message was not added, the user will get a message asking
                                 for a commit message. When this occurs the terminal will immediatley
                                 open Vim text-editor in the same terminal and will ask you to write
                                 a commit message. To do this, first press the 'I' key to enter "Insert"
                                 mode. Then type out your message. Finally, to save the text and
                                 close Vim, press the 'ESC' key and then type in ':wq' - which means
                                 'write' and 'quit'. The : symbol precedes a command. )

