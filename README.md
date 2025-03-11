# Cross-Reality-Environment-SpatialTouch
![Image](https://raw.githubusercontent.com/LixiangZhao98/asset/master/Project/Cross-reality-Environment-SpatialTouch/spatialtouch.gif "Image")
* This is a simulator of SpatialTouch, a novel cross-reality environment that seamlessly integrates a monoscopic 2D surface (an interactive screen with touch and pen input) with a stereoscopic 3D space (an augmented reality HMD) to host spatial data visualizations jointly. 
* The visualization below the screen is projected on the screen. The visualization above the screen is rendered in AR HMD. Two views are seamlessly combined into a `cohesive 3D representation` from the first-person view.
* Be noted that this is just a simulator to show the cameras' settings (position, orientation and projection matrix) for AR and surface rendering. The development toolkit for AR HMD and the communication across AR and screen devices are not included.

# Install the project and Play the demo
- Download Unity Hub. Please refer to sec.1-4 in [tutorial](https://github.com/LixiangZhao98/asset/blob/master/Tutorial/Unity_Setup_General.pdf) if you are a new Unity user.
- Clone the repo or download the archive [https://github.com/Cross-Reality-Environment-SpatialTouch/archive/refs/heads/master.zip](https://github.com/LixiangZhao98/Cross-Reality-Environment-SpatialTouch/archive/refs/heads/master.zip "archive") and open the project using Unity (versions equal to/higher than 2019 have been tested). Please refer to sec.6 in [tutorial](https://github.com/LixiangZhao98/asset/blob/master/Tutorial/Unity_Setup_General.pdf) if you don't know how to open an existing project.
- `Assets/Cross_Reality_Environment/Scenes/Cross Reality Setup_dragon.unity` is a demo scene.

# Control
* Use `WASD` to move your position.
* Hold `left mouse button` to change you direction.
* Use `Space Key` to reset you position.

## BibTex
```
@article{Zhao:2024:SES,
  author      = {Lixiang Zhao and Tobias Isenberg and Fuqi Xie and Hai-Ning Liang and Lingyun Yu},
  title       = {SpatialTouch: Exploring Spatial Data Visualizations in Cross-reality},
  journal     = {IEEE Transactions on Visualization and Computer Graphics},
  year        = {2024},
  volume      = {30},
  number      = {12},
  month       = dec,
  pages       = {},
  doi         = {10.1109/TVCG.2023.3326517},
  shortdoi    = {10/gtnn25},
  doi_url     = {https://doi.org/10.1109/TVCG.2024.3456368},
  oa_hal_url  = {},
  preprint    = {https://doi.org/10.48550/arXiv.2407.14833},
  osf_url     = {https://osf.io/avxr9/},
  url         = {https://tobias.isenberg.cc/p/Zhao2025SES},
  github_url  = {https://github.com/LixiangZhao98/Cross-Reality-Environment-SpatialTouch},
  pdf         = {https://tobias.isenberg.cc/personal/papers/Zhao_2025_SES.pdf},
  video       = {https://www.youtube.com/watch?v=GUXvZKqg-7s&t=111s},
}
```
