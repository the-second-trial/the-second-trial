###########
# install #
###########

# Assumption: following command must have been run first:
#             source .venv/bin/activate

# Install Sphinx
# https://www.sphinx-doc.org/en/master/tutorial/getting-started.html
python -m pip install sphinx

# Verify installation
sphinx-build --version

# ---

# Install the theme
# https://sphinx-book-theme.readthedocs.io/en/stable/tutorials/get-started.html
pip install sphinx-book-theme
