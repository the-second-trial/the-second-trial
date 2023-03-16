# Configuration file for the Sphinx documentation builder.
#
# For the full list of built-in configuration values, see the documentation:
# https://www.sphinx-doc.org/en/master/usage/configuration.html

from datetime import date

# -- Project information -----------------------------------------------------
# https://www.sphinx-doc.org/en/master/usage/configuration.html#project-information

project = "the-2nd-trial"
copyright = f"{date.today().year}, The 2nd Trial"
author = "Andrea Tino"
release = "1.0.0"

master_doc = "index"
html_title = "The 2nd Trial"
language = "en"


# -- General configuration ---------------------------------------------------
# https://www.sphinx-doc.org/en/master/usage/configuration.html#general-configuration

# Add any Sphinx extension module names here, as strings. They can be
# extensions coming with Sphinx (named 'sphinx.ext.*') or your custom
# ones.
extensions = [
    "myst_parser",
    "sphinx.ext.intersphinx",
    "sphinx.ext.viewcode",
    "sphinx.ext.autodoc",
    "sphinx.ext.autosummary",
    "sphinxemoji.sphinxemoji",
    "sphinxcontrib.jquery",
    "sphinx_disqus.disqus",
]

# Add any paths that contain templates here, relative to this directory.
templates_path = ["_templates"]

# List of patterns, relative to source directory, that match files and
# directories to ignore when looking for source files.
# This pattern also affects html_static_path and html_extra_path.
exclude_patterns = ["_build", "Thumbs.db", ".DS_Store"]


# -- Options for MyST --------------------------------------------------------
# https://myst-parser.readthedocs.io/en/stable/syntax/optional.html#math-shortcuts

myst_enable_extensions = [
    "amsmath",
    "attrs_inline",
    "colon_fence",
    "deflist",
    "dollarmath",
    "fieldlist",
    "html_admonition",
    "html_image",
    #"linkify",
    "replacements",
    "smartquotes",
    "strikethrough",
    "substitution",
]


# -- Options for HTML output -------------------------------------------------
# https://www.sphinx-doc.org/en/master/usage/configuration.html#options-for-html-output

html_theme = "sphinx_book_theme"
html_static_path = ["_static"]
html_title = "The 2nd Trial"

html_theme_options = {
    "repository_url": "https://github.com/the-second-trial/the-second-trial",
    "use_repository_button": True,
    "use_sidenotes": True,
    #"announcement": "<b>v0.19</b> is now out! See the Changelog for details",
}


# -- Options for Disqus ------------------------------------------------------
# https://sphinx-disqus.readthedocs.io/en/v1.2.0/install.html
disqus_shortname = "the2ndtrial"
