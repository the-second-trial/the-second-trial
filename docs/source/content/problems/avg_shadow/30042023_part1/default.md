---
myst:
  html_meta:
    "keywords": "problem, math, mathematics, probability, problem-solving"
---

# The average shadow of a line segment in 1 dimension

This is the simplest version of the _Average Shadow Problem_. All the conditions are the same as described in the generic formulation, with the following simplifications:

- The object is a line segment of given length $L \in \mathbb{R}$.
- The object rotates on one single plane.
- The shadow is projected onto a line, not a surface.

Thanks to the above, the whole exercise reduces to one single dimension.

```{raw} html
:file: ./anim.html
```

## Mathematical formulation
Let us translate the problem in mathematical terms. Since we are asked to compute an average, it is natural to think about a probability distribution of a random variable. The random variable is, in fact, the angle $\Theta \in [0, \pi]$[^sn-thetarange], which, alone, defines completely the orientation of $L$.

[^sn-thetarange]: We are assuming $\Theta$ to take values between $0$ and $\pi$ as it represents the minimal interval before seeing duplicate orientations. Considering a range in $[0, 2\pi]$, would introduce duplicate projections which would just complicate our calculations (as it will be pointed out later on).

The quantity whose average we want to find is the horizontal projection of $L$: $\Lambda \in [0, L]$, and it is related to $L$ by:

$$
\Lambda = L \cdot \cos \Theta
$$ (eq-proj)

Since $\Lambda$ depends on $\Theta$ by the relation: $\Lambda = g(\Theta)$, we have that $\Lambda$ itself is a random variable. Its distribution depends on the distribution of $\Theta$, and we can use this fact to draw our strategy to solve the problem:

```{prf:proposition} Solving strategy
:label: solve-strategy

1. Assume a probability distribution for $\Theta$, and obtain its PDF: $f_\Theta$.
2. Using the framework of _Random Variable Transformation_, compute the distribution of $\Lambda$ and its PDF: $f_\Lambda$.
3. From $\Lambda$'s PDF, compute the mean: $\mu_\Lambda = E[\Lambda]$.
```

## Solving the problem
As per {prf:ref}`solve-strategy`'s first point, we need to make an hypothesis on $f_\Theta$. The problem asks to compute the average shadow, but says nothing on the random behavior of the orientation of $L$. Here, we are not considering the occurrence of an event, or the analysis of a population; these fall in the domain of natural phenomena which would typically be modelled by assuming a Normal Distribution.

In this case, we are asked to consider all distinct values a certain variable can get, and take each one of them as having the same _importance_ or _relevance_. By assuming $\Theta$ to have a Uniform Distribution: $\Theta \sim \mathcal{U}[0, \pi]$, we fulfill such specification.

```{margin}
Function $\Pi(x) = \Pi_{[-\frac{1}{2}, \frac{1}{2}]}(x)$ is the [Boxcar Function](https://mathworld.wolfram.com/BoxcarFunction.html).
```

$$
f_\Theta(\theta) = \frac{1}{\pi} \Pi\left(\frac{\theta}{\pi} - \frac{1}{2}\right)
$$ (eq-thetadist)

We are now ready to move on to {prf:ref}`solve-strategy`'s second point. Knowing $f_\Theta$, as per equation {eq}`eq-thetadist`, is essential to compute $f_\Lambda$. The next job is computing the inverse of $g(\theta)$, that is: $g^{-1}(\lambda)$. From equation {eq}`eq-proj`, we can express $\Lambda$ as a function of $\Theta$ getting:

$$
g^{-1}(\lambda) = \arccos\left(\frac{\lambda}{L}\right)
$$ (eq-invg)

We have inverted the cosine function, which introduces a range validity[^sn-cosinv] we need to check. Given that $\arccos x : [-1, 1] \mapsto [0, \pi]$, and that $\lambda \in [-L, L]$[^sn-lambdarange]; we have that: $\frac{\lambda}{L} \in [-1, 1] \equiv [-1, 1]$. All is good and we can apply the main result of random variable transformation which allows us to compute $f_\Lambda$ given $f_\Theta$ and $g^{-1}$:

[^sn-cosinv]: Since function $\cos x$ is not fully invertible in its domain $\mathbb{R}$, a piece-wise inversion is required. The usual inversion branch is in $[0, \pi]$.

[^sn-lambdarange]: Given equation {eq}`eq-proj`, we can see that when $L$' starts tilting backwards ($\Theta > \frac{\pi}{2}$), the projection $\Lambda$ becomes negative.

$$
f_\Lambda(\lambda) = f_\Theta \left[ g^{-1}(\lambda) \right] \cdot \left| \frac{\mathrm d}{\mathrm d \lambda} g^{-1}(\lambda) \right|
$$ (eq-rvftrans)

Having equation {eq}`eq-rvftrans` in mind, let us plug in it all the quantities we now have ready:

$$
\begin{align}
  f_\Lambda(\lambda) &= f_\Theta \left[ \arccos\left(\frac{\lambda}{L}\right) \right] \cdot \left| \frac{\mathrm d}{\mathrm d \lambda} \arccos\left(\frac{\lambda}{L}\right) \right| \nonumber \\
                     &= f_\Theta \left[ \arccos\left(\frac{\lambda}{L}\right) \right] \cdot \left| -\frac{L^{-1}}{\sqrt{1 - L^{-2}\lambda^2}} \right| \nonumber \\
                     &= f_\Theta \left[ \arccos\left(\frac{\lambda}{L}\right) \right] \cdot \frac{L^{-1}}{\sqrt{1 - L^{-2}\lambda^2}} \nonumber \\
                     &= \Pi_{[-L, L]}(\lambda) \frac{1}{\pi} \frac{L^{-1}}{\sqrt{1 - L^{-2}\lambda^2}}
                      = \frac{\Pi_{[-L, L]}(\lambda)}{\pi L} \frac{1}{\sqrt{1 - L^{-2}\lambda^2}}
\end{align}
$$

Assuming, from now on, that $\lambda \in [-L, L]$, we have $\Lambda$'s PDF:

$$
f_\Lambda(\lambda) = \frac{1}{\pi L} \frac{1}{\sqrt{1 - L^{-2}\lambda^2}} \qquad {} -L \leq \lambda \leq L
$$ (eq-lambdapdf)

So, now we can jump to the last point of {prf:ref}`solve-strategy`. We can get the desired average by computing $\Lambda$'s mean $\mu_\Lambda$:

$$
\mu_\Lambda = E[\Lambda] = \int_{-L}^L \lambda f_\Lambda(\lambda) \cdot \mathrm d \lambda = \frac{1}{\pi L} \int_{-L}^L \frac{\lambda}{\sqrt{1 - L^{-2}\lambda^2}} \cdot \mathrm d \lambda
$$ (eq-lambdamu)

However we can immediately tell that **integral is zero** because the integration horizon is symmetric to the origin and the integrand is an odd function[^sn-integrandisodd], therefore: $\mu_\Lambda = 0$.

[^sn-integrandisodd]: It is easy to see that $\lambda \cdot f_\Lambda(\lambda)$ is odd because $\lambda$ is an odd function and $f_\Lambda$ is an even function. The product between an odd and an even function always yields an odd function.

### Some adjustments
The result we found is not entirely surprising: we can see that for each projection $\Lambda(\Theta) > 0$, there is a symmetric $\Lambda(\Theta + 90^\circ) = - \Lambda(\Theta)$ projection occurring with the same exact probability. This causes the mean to be zero.

We could probably see something more interesting, if we considered all negative projections as positive: we would still consider $\Theta \in [0, \pi]$, but we would redesign $g$ to have: $\Lambda = | L \cdot \cos \Theta |$. However, introducing an absolute value means having branchy calculations ahead of us; we can achieve the same result by rather restricting the inclination angle to be: $\Theta \in [0, \frac{\pi}{2}]$ so that $\cos(\Theta)$ is always positive.

This way, we only need to adjust $f_\Theta(\theta)$, and {eq}`eq-thetadist` now becomes:

$$
f_\Theta(\theta) = \frac{2}{\pi} \Pi\left(\frac{2}{\pi} \theta - \frac{1}{2}\right)
$$ (eq-thetadist2)

## Comments

```{disqus}
```
