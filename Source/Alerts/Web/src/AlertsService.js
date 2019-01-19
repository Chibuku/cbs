import {BaseApi} from '@ifrc-cbs/common-react-ui';

import { CommandCoordinator } from '@dolittle/commands';
import { QueryCoordinator } from '@dolittle/queries';
import { AddRule } from '../Features/Rules/AddRule';

import { AllRules } from '../Features/Rules/AllRules';

export default class Alerts extends BaseApi {

    constructor() {
        let commandCoordinator = new CommandCoordinator();
        let command = new AddRule();
        commandCoordinator.handle(command).then(result => {

        });

        let queryCoordinator = new QueryCoordinator();
        let query = new AllRules();
        queryCoordinator.execute(query).then(result => {

        });



    }
};



