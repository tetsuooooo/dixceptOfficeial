<template>
    <v-container fluid>
        <v-row>
            <v-col cols="11" sm="3">
                <v-btn>新規登録</v-btn>
            </v-col>
        </v-row>
        <v-row justify="center">
            <v-col cols="11">
                <v-data-table :headers="headers" :items="items">
                    <template #item.edit="{item}">
                        <v-btn @click.stop="dialog = true" icon x-small>
                            <v-icon>fas fa-edit</v-icon>
                        </v-btn>
                    </template>
                    <template #item.delete="{item}">
                        <v-btn @click.stop="deleteItem" icon x-small>
                            <v-icon>fas fa-trash-alt</v-icon>
                        </v-btn>
                    </template>
                </v-data-table>
            </v-col>
        </v-row>

        <!-- モーダル -->
        <v-dialog v-model="dialog" width="500">
            <v-card>
                <!-- 戻るボタン -->
                <v-row justify="end">
                    <v-col cols="2" sm="2" class="text-right">
                        <v-btn icon small @click="dialog = false"><v-icon>fas fa-times</v-icon></v-btn>
                    </v-col>
                </v-row>
                <v-card-text>
                    <ValidationObserver ref="observer" #default="{invalid}" immediate>
                        <form>
                            <v-row justify="center">
                                <v-col cols="7">
                                    <v-select label="大会" v-model.number="torunament" :items="torunaments" item-text="label" item-value="value" prepend-icon="fas fa-trophy"></v-select>
                                </v-col>
                            </v-row>
                            <v-row justify="center">
                                <v-col cols="7">
                                    <v-select label="対戦相手" v-model.number="opponent" :items="opponents" item-text="label" item-value="value" prepend-icon="fas fa-users"></v-select>
                                </v-col>
                            </v-row>
                            <v-row justify="center">
                                <ValidationProvider #default="{errors, valid}" name="節" rules="required|numeric">
                                    <v-text-field v-model.number="section" :error-messages="errors" label="節" required :success="valid" clearable prepend-icon="fas fa-sort-numeric-up"></v-text-field>
                                </ValidationProvider>
                            </v-row>
                            <v-row justify="center">
                                <v-menu ref="menu" v-model="menu" :close-on-content-click="false" :return-value.sync="date" transition="scale-trantision" offset-y min-width="auto">
                                    <template #activator="{on, attrs}">
                                        <ValidationProvider #default="{errors, valid}" name="日付" rules="required">
                                            <v-text-field readonly v-bind="attrs" v-on="on" v-model="date" :error-messages="errors" label="日付" required :succcess="valid" clearable prepend-icon="fas fa-table"></v-text-field>
                                        </ValidationProvider>
                                    </template>
                                    <v-date-picker v-model="date" color="green" elevetion="15">
                                        <v-spacer></v-spacer>
                                        <v-btn text color="primary" @click="menu = false">Cancel</v-btn>
                                        <v-btn text color="primary" @click="$refs.menu.save(date)">OK</v-btn>
                                    </v-date-picker>
                                </v-menu>
                            </v-row>
                            <v-row justify="center">
                                <ValidationProvider #default="{errors, valid}" name="時間" rules="required|time">
                                    <v-text-field v-model="time" :error-messages="errors" label="時間" required :success="valid" clearable prepend-icon="far fa-clock"></v-text-field>
                                </ValidationProvider>
                            </v-row>
                            <v-row justify="center">
                                <ValidationProvider #default="{errors, valid}" name="会場" rules="required">
                                    <v-text-field v-model="place" :error-messages="errors" label="会場" requiered :success="valid" clearable prepend-icon="fas fa-location-arrow"></v-text-field>
                                </ValidationProvider>
                            </v-row>
                            <v-row justify="center">
                                <v-col cols="12" sm="2">
                                    <v-btn @click="submit" :disabled="invalid" color="success">登録</v-btn>
                                </v-col>
                            </v-row>
                        </form>
                    </ValidationObserver>
                </v-card-text>
            </v-card>
        </v-dialog>
    </v-container>
</template>

<script lang="ts">
import {Component, Vue} from 'vue-property-decorator';
import {methods} from '@/common/commonMethod';
@Component({
    mixins:[methods]
})
export default class Schedule extends Vue{
    deleteItem(id: number){
        confirm('選択した予定を削除してよろしいですか?')
    }
     submit() {
            // 登録できている場合はtrue
            this.$refs.observer.validate().then(result => {
                console.log('submit', result);
            });
        }
    data(){
        return{
            menu: false,
            torunament: 1,
            section: 1,
            date: '2020-05-20',
            time: '10:00',
            opponent: 1,
            place: '会場',
            torunaments: [
                {
                    label: '埼玉県県リーグ2部',
                    value: 1
                },
                {
                    label: 'なんかの大会',
                    value: 2
                }
            ],
            opponents:[
                { label: '対戦相手1', value: 1},
                { label: '対戦相手1', value: 2},
            ],
            dialog: false,
            headers: [
                {
                    text: '大会名',
                    value: 'tournament',
                    align: 'center'
                },
                {
                    text: '節',
                    value: 'section',
                    align: 'center'
                },
                {
                    text: '日付',
                    value: 'date',
                    align: 'center'
                },
                {
                    text: '対戦相手',
                    value: 'opponent',
                    align: 'center'
                },
                {
                    text: '編集',
                    value: 'edit',
                    sortable: false,
                    align: 'center'
                },
                {
                    text: '削除',
                    value: 'delete',
                    sortable: false,
                    align: 'center'
                },
            ],
            items: [
                {
                    tournament: '埼玉県県リーグ2部',
                    section: '1',
                    date: '2021/05/20',
                    opponent: '対戦相手',
                    edit: 1,
                    delete: 1
                },
                {
                    tournament: '埼玉県県リーグ2部',
                    section: '1',
                    date: '2021/05/20',
                    opponent: '対戦相手',
                    edit: 1,
                    delete: 1
                },
            ]
        }
    }
}

</script>

<style scoped>

</style>
