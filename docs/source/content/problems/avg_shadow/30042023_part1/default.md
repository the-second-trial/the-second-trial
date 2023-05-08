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

## Mathematical formulation
Let us translate the problem in mathematical terms. Since we are asked to compute an average, it is natural to think about a probability distribution of a random variable. The random variable is, in fact, the angle $\Theta \in [0, \pi]$, which, alone, defines completely the orientation of $L$.

The quantity whose average we want to find is the horizontal projection of $L$: $\Lambda \in [0, L]$, and it is related to $L$ by:

$$
\Lambda = L \cdot \cos \Theta
$$ (eq_proj)

Since $\Lambda$ depends on $\Theta$ by the relation: $\Lambda = g(\Theta)$, we have that $\Lambda$ itself is a random variable. Its distribution depends on the distribution of $\Theta$, and we can use this fact to draw our strategy to solve the problem:

1. Assume a probability distribution for $\Theta$, and obtain its PDF: $f_\Theta$.
2. Using the framework of Random Variable Transformation, compute the distribution of $\Lambda$ and its PDF: $f_\Lambda$.
3. From $\Lambda$'s PDF, compute the mean: $\mu_\Lambda = E[\Lambda]$.

sdf

## Comments

```{disqus}
```
