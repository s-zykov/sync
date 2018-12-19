# *.md is a markdown

#########################################
#git add all
git add .

#########################################
#commit changes to current branch
git commit -m "comment"

#########################################
#create new branch
git branch mybranch_login

#########################################
#switch branch
git checkout mybranch_login

#########################################
#switch to master branch
git checkout master

#########################################
#When you are in master branch you can merge
git merge mybranch_login

============================================
REMOTE REPOSITORY
============================================

#########################################
#list current remote repositories
git remote

#########################################
#add a remote repository
git remote add origin https://github.com/...


#########################################
#push to remote repository
git push

#########################################
#clone repository
git clone https://github.com/..../project.git

#########################################
#pulls changes from the remote repository
git pull



############################
#git ignore. Exclude bin folders
#add to .gitignore
bin/

# If you already have any bin folders in your git index which you no longer wish to track then you need to remove them explicitly. Git won't stop tracking paths that are already being tracked just because they now match a new .gitignore pattern. Execute a folder remove (rm) from index only (--cached) recursivelly (-r). Command line example for root bin folder:
git rm -r --cached bin