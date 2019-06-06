#!/bin/bash

ssh-keygen -o -f ~/.ssh/id_rsa
cat ~/.ssh/id_rsa.pub | clip
