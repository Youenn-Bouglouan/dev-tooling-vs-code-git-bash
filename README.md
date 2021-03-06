# <span style="color:orange">Dev Tooling - Introducing Visual Studio Code and Git Bash</span>

#### L&L - Youenn Bouglouan - January 2019

---
## <span style="color:orange">Visual Studio Code</span>

Available for free at <b>https://code.visualstudio.com/</b>

Amongst others:
- text editor on steroids
- advanced IDE functionalities like Intellisense, debugging, code navigation
- lightweight
- cross-platform (Windows / Linux / Mac)
- integrated console / terminal
- built-in git support
- built-in markdown support
- built-in file comparison / diff tool

### <span style="color:orange">Languages supported</span>

Language extensions are available for all major programming languages. They include support for:
- syntax highlighting
- linting
- debugging
- code completion
- code navigation
- code snippets
- refactoring

![find language extensions](assets/find-language-extensions.gif)

Languages extensions that I've used so far:
<em>C#, F#, Elm, Elixir, Kotlin, Go, Rust, JavaScript</em>

### <span style="color:orange">Useful extensions</span>

1. <b>GitLens</b> - add advanced git support directly from your files
2. <b>REST Client</b> - send HTTP requests and display responses from VS Code
3. <b>Excel Viewer</b> - preview Excel and CSV files from VS Code
4. <b>Bookmarks</b> - create bookmarks in your files and quickly jump between them
5. <b>vscode-icons</b> - nice set of icons for the file explorer
6. <b>MySQL</b> - run MySQL queries from within VS Code
7. <b>SQL Server (mssql)</b> - run SQL Server queries from within VS Code

### <span style="color:orange">Useful shortcuts</span>

<b><cite>CTRL+SHIFT+P - One shortcut to rule them all!</cite></b>

- <b>CTRL+P</b>: go to file
- <b>CTRL+T</b>: go to member (class, function, property...)
- <b>CTRL+SHIFT+F</b>: search text in all files
- <b>CTRL+B</b>: toggle side bar visibility
- <b>CTRL+ALT+F</b>: format document

### <span style="color:orange">Tips and tricks</span>

1. Quick renaming with <b>CTRL+D</b>

2. Hide folders that you don't need

    - create a `.vscode` folder
    - create a `settings.json` file with the following content
    ```json
    {
        "files.exclude": {
            "**/bin": true,
            "**/obj": true
        }
    }
    ```

3. Maximize Editor Group

    - press <b>CTRL+SHIFT+P</b>
    - type `Maximize Editor Group`
    - the current editor window will maximize automatically

4. Disable extensions per workspace

![find language extensions](assets/disable-extension-per-workspace.gif)

### <span style="color:orange">Code, test, and debug a C# web service</span>

<b>live demo, baby!</b>

```json
// add this to launch.json to change the web service's port
"ASPNETCORE_URLS": "http://localhost:5555"
```

---
## <span style="color:orange">Git Bash</span>

Available for free at <b>https://gitforwindows.org/</b>
(Part of the standard Git installer!)

Amongst others:
- command line shell for Windows
- but... supports Unix commands and utilities, yeah!
- comes by default with Git
- almost zero configuration needed!

### <span style="color:orange">Aliases</span>

Check your list of aliases by typing:

```bash
$ alias
```

Add new aliases by typing:

```bash
$ code ~/.bashrc
```

For instance, add an alias to add aliases!

```bash
# shell
alias add-alias='code ~/.bashrc'
alias refresh='source ~/.bashrc'
```

### <span style="color:orange">Useful commands (Unix and other)</span>

```bash
# General Windows commands
> explorer . # open the Windows file explorer in the current location
> code . # open VS code in the the current location

# General Unix commands
> mkdir my-folder # create a new folder called my-folder
> touch file.txt # create a new file called file.txt
> cd my-folder # go into the my-folder
> cd .. # go back to the parent folder
> mv file.txt ./my-folder # move file.txt to my-folder
> rm -rf file.txt # remove permanently file.txt
> cat file.txt # print the content of file.txt in the console
> cat file.txt | grep <some word> # search for the given word inside file.txt
> ls -a # print list of files and folders from the current location, including hidden items
> echo $MY_ENV_VARIABLE # print the value of the given environment variable
> exit # exit the current session
> clear # clear the current output in the console

# Git commands
> git checkout -b new-branch # create a new branch called new-branch
> git add . # stage all your current changes
> git commit -m "some commit message" # commit your local changes to the current local branch
> git pull # pull latest changes from the repo for the current local branch
> git push # push your changes to the repo for the current local branch
> git reset --hard HEAD # reset all your current, uncommitted changes
> git log --graph --pretty=format:"%Cred%h%Creset %Cgreen(%cr) %C(bold blue)<%an>%Creset -%C(yellow)%d%Creset %s" --abbrev-commit -n 20 # pretty-print the latest 20 commits on the current branch

# Docker commands
> docker --help # print the help and the list of available commands for docker
> docker ps # list all running containers
> docker logs container-id # print logs for the given container
> winpty docker exec -i -t <container id> sh # bash into the given docker container
> docker rm -f container-id # remove the container with the given id
> docker container rm -f $(docker container ls -a -q) # remove all running containers
> docker container rm -f $(docker container ls --filter "name=hello" -q) # remove all containers with 'hello' in their name
```

### <span style="color:orange">Scripting examples</span>

<b>live demo, baby!</b>
