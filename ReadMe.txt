What is the architecture of the Application?
    --Core web API solution --Done
    --Unit Test solution --Done
    --GitHub Account(Repository is created) -- Started
    --Devops(Integration of repository - Achieving Continous Integration)
    --Azure(with Devops with GitHub Repository with Application - Continous Deployment)


dotnet new  sln --name corewebapp 
dotnet sln add src\corewebapp\corewebapp.csproj   
dotnet sln add Test\corewebappTest\corewebappTest.csproj


dotnet add Test\corewebappTest\corewebappTest.csproj reference src\corewebapp\corewebapp.csproj



    GitHub Repository - https://github.com/ygoyal3/DotNetCoreAp.git

    Git Commands:
    echo "# DotNetCoreAp" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/tausheemshakil/DotnetCICDsandeep.git

git add .
git commit -m "initial commit"
git push -u origin main


git push -u origin main


thia is Deployment
