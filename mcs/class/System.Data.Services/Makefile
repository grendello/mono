thisdir = class/System.Data.Services
SUBDIRS = 
include ../../build/rules.make

LIBRARY = System.Data.Services.dll

LIB_MCS_FLAGS = \
	-r:System.dll \
	-r:System.Core.dll \
	-r:System.ServiceModel.dll \
	-r:System.ServiceModel.Web.dll \

ifeq (4, $(FRAMEWORK_VERSION_MAJOR))
LIB_MCS_FLAGS += -r:System.Data.Services.Client.dll
endif

LIB_MCS_FLAGS += -d:NET_3_5

ifeq (4, $(FRAMEWORK_VERSION_MAJOR))
LIB_MCS_FLAGS += -d:NET_4_0
endif

# This is a .NET 3.5+ assembly
VALID_PROFILE := $(filter 4.0 2.0, $(FRAMEWORK_VERSION))
ifndef VALID_PROFILE
LIBRARY_NAME = dummy-System.Data.Services.dll
NO_INSTALL = yes
NO_SIGN_ASSEMBLY = yes
NO_TEST = yes
endif

include ../../build/library.make
