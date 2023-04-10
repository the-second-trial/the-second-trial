---
myst:
  html_meta:
    "keywords": "problem, math, mathematics, optimization, problem-solving"
---

# Cooking cookies in the oven... the difficult way

So, one day I was browsing through videos about cookies[^sn-cookie] and how to make them, and I noticed a common issue mentioned by all those guys running culinary shows: in the final stage when the cookies had to be baked, it was important to make sure they would get placed on the tray well diatanced apart from each other to ensure they would not merge once collapsing and expanding.

If you are not familiar with the art of baking cookies, this is what you need to know. After making the dough, you need to scoop it in little balls before baking them. The balls then will flatten and spread on the tray, raising into the round shape cookies normally have. The issue is that, if you do not space the balls of dough enough from each other, you will end up with some cookies melting together, and you do not want that. To tackle this, all these youtubers will tell you to place the cookies on the tray in certain positions. What we want to do is putting some more rigor into this exercise and find the best placement guaranteeing the perfect placement.

## An optimization problem

What we need to do, is translating this problem into an _optimization problem_, which in the world of Pure Mathematics is more commonly referred to as: [Mathematical Programing](https://en.wikipedia.org/wiki/Mathematical_optimization). The first step is identifying what quantity we want to minimize or maximize.

[^sn-cookie]: I like cooking, so I watch a lot of culinary shows on YouTube :kissing:.

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
