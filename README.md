# jdproj005
New Repository To Introduce TDD with .Net



#Commands used to setup the Project

devjaikumar@Lenovo:~/2023/202308/20230805/jdproj005$ history
    1  git clone git@github.com:devjaikumar001/jdproj005.git
    2  ssh-keygen -T ed25519 -C dev.jaikumar001@gmail.com
    3  ssh-keygen -t ed25519 -c dev.jaikumar001@gmail.com
    4  ssh-keygen -t ed25519 -c "dev.jaikumar001@gmail.com"
    5  ssh-keygen -t ed25519 -C "dev.jaikumar001@gmail.com"
    6  code ~/.ssh/id_ed25519.pub
    7  git clone git@github.com:devjaikumar001/jdproj005.git
    8  dotnet
    9  sudo snap install dotnet-sdk
   10  sudo snap install dotnet-sdk --classic
   11  cd jdproj005/
   12  code .
   13  git status
   14  git branch users/jd/20230805_InitialSetup
   15  git checkout users/jd/20230805_InitialSetup
   16  git branch
   17  dotnet new xunit ProjCB.Tests
   18  dotnet new xunit -o ProjCB.Tests
   19  cd ProjCB.Tests/
   20  dotnet new gitignore
   21  code .
   22  cd ~
   23  ll
   24  cd 2023/202308/20230805/jdproj005/
   25  code .
   26  dotnet test
   27  cd ProjCB.Tests/
   28  dotnet test
   29  cd ..
   30  git add -A
   31  git commit -am "Created Initial Unit Test Project"
   32  git config --global user.email "dev.jaikumar002@gmail.com"
   33  git config --global user.name "dev.jaikumar001"
   34  git config --global user.email "dev.jaikumar001@gmail.com"
   35  git commit -am "Created Initial Unit Test Project"
   36  git push
   37  git checkout -b users/jd/20230805_Creating_CBProject
   38  dotnet new classlib -o ProjCB
   39  cd ProjCB
   40  dotnet new gitignore
   41  cd ..
   42  dotnet new solution   
   44  dotnet sln add ./ProjCB/ProjCB.csproj
   45  dotnet sln add ./ProjCB.Tests/ProjCB.Tests.csproj
   46  history