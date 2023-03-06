#########
# build #
#########

# Assumption: following command must have been run first:
#             source .venv/bin/activate

sphinx-build -b html docs/source/ docs/build/html
