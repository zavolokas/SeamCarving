# Seam Carving
[![license](https://img.shields.io/github/license/mashape/apistatus.svg?style=flat-square)]()
[![Build Status](https://travis-ci.org/zavolokas/SeamCarving.svg?branch=master)](https://travis-ci.org/zavolokas/SeamCarving)

Seam carving (or liquid rescaling) is an algorithm for content-aware image resizing. It functions by establishing a number of seams (paths of least importance) in an image and automatically removes seams to reduce image size or inserts seams to extend it. Seam carving also allows manually defining areas in which pixels may not be modified, and features the ability to remove whole objects from photographs.

| Dest image | Markup | Result |
| ----------- | ------ | ------ |
| ![input1]   | ![input2] | ![result] |

The purpose of the algorithm is image retargeting, which is the problem of displaying images without distortion on media of various sizes (cell phones, projection screens) using document standards, like HTML, that already support dynamic changes in page layout and text but not images.

The algorithm is developed by Shai Avidan, of Mitsubishi Electric Research Laboratories (MERL), and Ariel Shamir, of the Interdisciplinary Center and MERL.

[input1]: images/t001.png "dest image"
[input2]: images/m001.png "markup image"
[result]: images/r001.png "result image"
