###########
# install #
###########

# Assumption: following command must have been run first:
#             1. Run create-env.sh first to create the venv
#             2. Run source .venv/bin/activate to activate the environment

# - Sphinx ---

# Install Sphinx
# https://www.sphinx-doc.org/en/master/tutorial/getting-started.html
python3 -m pip install sphinx

# Verify installation
sphinx-build --version

# - Sphinx accessories ---

# Install the theme
# https://sphinx-book-theme.readthedocs.io/en/stable/tutorials/get-started.html
pip3 install sphinx-book-theme --upgrade

# Install required extensions
pip3 install myst-parser --upgrade             # MyST parser
pip3 install sphinxemoji --upgrade             # Emoji
pip3 install sphinxcontrib.jquery --upgrade    # Sphinx newer versions do not add jQuery, this ensures the library is available, following extensions need it>
                                     #     - sphinx-disqus
pip3 install sphinx-disqus --upgrade           # Commenting
pip3 install sphinx-proof --upgrade            # Proof environments

# - Jupyter ---

# Install Jupyter and Jupyter Notebook
# https://jupyter.org/install
pip3 install jupyterlab --upgrade
pip3 install notebook --upgrade

# Make this environment available to Jupyter Notebooks used for post materials
python3 -m ipykernel install --user --name=t2t-env

# - Accessory scientific libraries ---

# Plotting
pip3 install matplotlib --upgrade

# Numerical analysis
pip3 install numpy --upgrade

# Sympy
pip3 install mpmath --upgrade
pip3 install sympy --upgrade

# Statsmodels
pip3 install statsmodels --upgrade
