# This bash script uses git to synchronize changes between the local and remote GitHub repository.
# TODO: Ask copilot chat to review the script and suggest improvements.

git add .

git commit -m "Updated"

git pull origin main

git push 

# Check if the push was successful
if [ $? -eq 0 ]; then
    echo "Changes pushed successfully to the remote repository."
else
    echo "Failed to push changes to the remote repository. Please check for conflicts or errors."
fi





