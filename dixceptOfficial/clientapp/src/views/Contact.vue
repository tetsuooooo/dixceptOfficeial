<template>
    <div>
        <v-row>
            <v-col cols="12">
                <v-img :src="require('../assets/NoImg.png')" width="100%" height="40vh"></v-img>
            </v-col>
        </v-row>
        <v-row justify="center">
            <form>
                <v-col cols="10" class="mt-5">
                    <v-row>
                        <v-col cols="12" class="text-h4 text-center">お問合せフォーム</v-col>
                    </v-row>
                    <v-row justify="center">
                        <v-col cols="6">
                            <v-text-field v-model="name" :counter="nameMax" :rules="nameRules" label="お名前" placeholder="お名前"></v-text-field>
                        </v-col>
                    </v-row>
                    <v-row justify="center">
                        <v-col cols="6">
                            <v-text-field v-model="teamName" :counter="teamNameMax" :rules="teamRules" label="チーム名" placeholder="チーム名"></v-text-field>
                        </v-col>
                    </v-row>
                    <v-row justify="center">
                        <v-col cols="6">
                            <v-text-field v-model="mailAddress" :rules="mailRules" label="メールアドレス" placeholder="メールアドレス"></v-text-field>
                        </v-col>
                    </v-row>
                    <v-row justify="end">
                        <v-col cols="2">
                            <v-btn @click="submit">
                                送信
                            </v-btn>
                        </v-col>
                    </v-row>
                </v-col>
            </form>
        </v-row>
    </div>
</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';

    @Component({
        components: {
            
        },
    })
    export default class Contact extends Vue {
        data(){
            const nameMax = 30
            const teamNameMax = 100
            return {
                mailAddress: '',
                teamName: '',
                name: '',
                nameMax,
                teamNameMax,
                nameRules: [
                    v => !!v || '',
                    v => (!!v && nameMax >= v.lemgth) || `${nameMax}文字以内で入力してください`
                ],
                teamRules: [
                    v => (!!v && teamNameMax >= v.lemgth) || `${teamNameMax}文字以内で入力してください`
                ],
                mailRules:[
                    v => !!v || '',
                    v => /.+@.+\..+/.test(v) || 'メールアドレスを正しい形式で入力してください'
                ],
            }
        }
        submit(){
            this.$v.$touch()
        }
    }
</script>

<style scoped>
.border_left{
        border-left: solid 5px green;
    }
</style>
