---
myst:
  html_meta:
    "keywords": "problem, math, mathematics, optimization, problem-solving"
---

# Baking cookies... the hard way

So, one day I was browsing through videos about cookies[^sn-cookie] and how to make them, and I noticed a common issue mentioned by all those guys running culinary shows: in the final stage when the cookies had to be baked, it is important they get placed on the tray well diatanced apart from each other to ensure they would not merge once collapsing and expanding.

[^sn-cookie]: I like cooking, so I watch a lot of culinary shows on YouTube.

If you are not familiar with the art of baking cookies, this is what you need to know. After making the dough, you need to scoop it in little balls before baking them. The balls then will flatten and spread on the tray, raising into the round shape cookies normally have. The issue is that, if you do not space the balls of dough apart enough from each other, you will end up with some cookies melting together, and you do not want that. To tackle this, all these youtubers will tell you to place the cookies on the tray in certain positions. What I want to do is putting some more rigor into this exercise and find the best placement(s) guaranteeing the perfect baking.

## An optimization problem

What we must do, is translating this problem into an _optimization problem_, which in the world of Pure Mathematics is more commonly referred to as: [Mathematical Programing](https://en.wikipedia.org/wiki/Mathematical_optimization). We need to identify

- The _target_ quantity we want to minimize or maximize.
- The variables[^sn-searchspace] the target depends on.
- The _constrainsts_ associated to the variables.

[^sn-searchspace]: The space originated by them is referred to as: _search space_.

Since we need to simplify things, we can consider our $N \in \mathbb{N}^+$ cookies as circles[^sn-cookiesascircles] all of the same size, hence with common radius $R \in \mathbb{R}^+$. We can consider our baking tray as a rectangle of width and height: $w,h \in \mathbb{R}^+$. Finally, as we will need to refer to positions, we can set up a classic reference frame originating from the bottom-left corner of the tray.

[^sn-cookiesascircles]: We consider the cookies at the end of baking, after the dough has collapsed and expanded.

### Choosing the optimization target
To space out the circles on the rectangle as much as we can, we need to find a (scalar) quantity that can describe the _degree of spacing_. The circles will form a [simple polygon](https://en.wikipedia.org/wiki/Simple_polygon)[^sn-smplpoly]; from this fact, we can try finding one of its descriptors to act as a suitable target. The following options all relate to the distance between the vertices (our cookies):

[^sn-smplpoly]: By connecting all centers, a convex hole-free polygon will originate.

- The perimeter $P \in \mathbb{R}$.
- The area/surface $S \in \mathbb{R}$.
- The [centroid](https://en.wikipedia.org/wiki/Centroid) $C \in \mathbb{R}^2$.

Instead of going by _gut feeling_, and selecting the option I think works best, I have run a few simulations by: creating some points over a fixed plane, constructing the polygon, and measuring the 3 quantities above. More details on the simulations are availabel in the attached Jupyter notebook, the results confirm that the **surface** is the best descriptor to use as target quantity.

```
                            OLS Regression Results                            
==============================================================================
Dep. Variable:                      y   R-squared:                       0.376
Model:                            OLS   Adj. R-squared:                  0.343
Method:                 Least Squares   F-statistic:                     11.26
Date:                Sun, 30 Apr 2023   Prob (F-statistic):           6.94e-06
Time:                        21:56:32   Log-Likelihood:                 125.02
No. Observations:                  60   AIC:                            -242.0
Df Residuals:                      56   BIC:                            -233.7
Df Model:                           3                                         
Covariance Type:            nonrobust                                         
==============================================================================
                 coef    std err          t      P>|t|      [0.025      0.975]
------------------------------------------------------------------------------
const          0.0260      0.028      0.915      0.364      -0.031       0.083
x1             0.0712      0.025      2.880      0.006       0.022       0.121
x2             0.2311      0.089      2.603      0.012       0.053       0.409
x3            -0.0754      0.026     -2.956      0.005      -0.127      -0.024
==============================================================================
Omnibus:                        0.887   Durbin-Watson:                   0.873
Prob(Omnibus):                  0.642   Jarque-Bera (JB):                0.978
Skew:                          -0.246   Prob(JB):                        0.613
Kurtosis:                       2.614   Cond. No.                         73.3
==============================================================================

Notes:
[1] Standard Errors assume that the covariance matrix of the errors is correctly specified.
```

```{prf:proposition} Problem formulation
**Minimize** function $f(x)$.
```

And that basically got me thinking about an exact way to mathematically solve this cookie-baking challenge which can be resumed as such:

Something to do.
Here's my sentence and a sidenote[^sn2].

[^sn2]: And here's my sidenote content.

Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc lacus quam, vestibulum nec suscipit et, varius ac metus. Aliquam consectetur, nisl et posuere malesuada, orci urna cursus augue, et fermentum velit diam eget magna. Nam aliquet elit ac condimentum pulvinar. Vestibulum sapien mi, tempor non lectus sit amet, auctor dignissim nunc. Quisque nec ligula ac ante efficitur vulputate. Quisque imperdiet tincidunt $log(x)$ ante, at luctus justo lobortis tincidunt dfdf.

$$
\int_{-\infty}^{+\infty} e^{-t^3} dt
$$ (eq1)

Proin ligula diam equation {eq}`eq1`, fringilla vel erat id, finibus interdum odio. Suspendisse dapibus nulla et justo sodales laoreet. Vestibulum accumsan, ipsum et mattis congue, sapien enim consequat ex, ut eleifend ipsum felis non nibh. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Duis at euismod arcu. Nulla euismod, nulla eget congue rutrum, sapien nisl tincidunt urna, imperdiet euismod metus ante nec magna. Pellentesque sed lacinia tortor.

```{margin} Look, some margin content!
On wider screens, this content will pop out to the side!
```

Praesent sit amet leo blandit, auctor mi vel, interdum enim. Aenean gravida eros et erat auctor pretium. Praesent suscipit eros et risus convallis, eget viverra mi placerat. Maecenas nec ligula sed ipsum tristique volutpat. Sed facilisis laoreet dui, vel pretium nisi tempus sit amet. Nunc sollicitudin nisl quis mi sollicitudin, a consequat nulla commodo. Aliquam vestibulum nibh id leo sagittis auctor. Curabitur varius nisl arcu, sit amet facilisis lacus volutpat sed. In ornare quam sed vulputate semper. Nulla sodales erat ut nunc lacinia, sit amet viverra libero consequat. Pellentesque at massa scelerisque, congue turpis eu, tincidunt neque. Interdum et malesuada fames ac ante ipsum primis in faucibus.

Something more in here and more.

````{prf:definition}
:label: my-definition

The *economical expansion problem* (EEP) for
$(A,B)$ is to find a semi-positive $n$-vector $p>0$
and a number $\beta\in\mathbb{R}$, such that

$$
&\min_{\beta} \hspace{2mm} \beta \\
&\text{s.t. }\hspace{2mm}Bp \leq \beta Ap
$$
````

And here as well.

````{prf:theorem} Orthogonal-Projection-Theorem
:label: my-theorem

Given $y \in \mathbb R^n$ and linear subspace $S \subset \mathbb R^n$,
there exists a unique solution to the minimization problem

```{math}
\hat y := \argmin_{z \in S} \|y - z\|
```

The minimizer $\hat y$ is the unique vector in $\mathbb R^n$ that satisfies

* $\hat y \in S$

* $y - \hat y \perp S$


The vector $\hat y$ is called the **orthogonal projection** of $y$ onto $S$.
````

And how about this:

````{prf:lemma}
:label: my-lemma

If $\hat P$ is the fixed point of the map $\mathcal B \circ \mathcal D$ and $\hat F$ is the robust policy as given in [(7)](https://python-advanced.quantecon.org/robustness.html#equation-rb-oc-ih), then

```{math}
:label: rb_kft

K(\hat F, \theta) = (\theta I - C'\hat P C)^{-1} C' \hat P  (A - B \hat F)
```
````

Something more in here and more.

## Comments

```{disqus}
```
