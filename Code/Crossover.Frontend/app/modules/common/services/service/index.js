﻿(function () {

    'use strict';

    angular.module('modules.common.services.service', [
        'modules.common.services.service.retryQueue',
        'modules.common.services.service.security',
        'modules.common.services.service.excecao',
        'modules.common.services.service.notificacao',
        'modules.common.services.service.viewstate'
    ]);

})();