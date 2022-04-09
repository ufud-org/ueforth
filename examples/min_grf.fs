#! /usr/bin/env ueforth
\ Copyright 2022 Bradley D. Nelson
\
\ Licensed under the Apache License, Version 2.0 (the "License");
\ you may not use this file except in compliance with the License.
\ You may obtain a copy of the License at
\
\     http://www.apache.org/licenses/LICENSE-2.0
\
\ Unless required by applicable law or agreed to in writing, software
\ distributed under the License is distributed on an "AS IS" BASIS,
\ WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
\ See the License for the specific language governing permissions and
\ limitations under the License.

graphics

-1 -1 window

$ff0000 constant red
$ffff00 constant yellow
$000000 constant black

: draw
  black to color  0 0 width height box
  yellow to color  0 0 width 2/ height 2/ box
  red to color    mouse-x mouse-y width 10 / height 10 / box
  flip
;

: run
  begin
    poll
    IDLE event = if draw then
  event FINISHED = until
  bye
;
run
